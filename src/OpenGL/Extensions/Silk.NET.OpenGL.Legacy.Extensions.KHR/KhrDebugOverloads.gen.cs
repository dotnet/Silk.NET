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

namespace Silk.NET.OpenGL.Legacy.Extensions.KHR
{
    public static class KhrDebugOverloads
    {
        public static unsafe void DebugMessageCallback<T0>(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProc callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> userParam) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DebugMessageCallback(callback, in userParam.GetPinnableReference());
        }

        public static unsafe void DebugMessageControl(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageInsert(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), label);
        }

        public static unsafe void GetObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ObjectIdentifier identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ObjectIdentifier identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ObjectIdentifier identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), label);
        }

        public static unsafe void GetObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ObjectIdentifier identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ObjectIdentifier identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(ptr, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(ptr, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* label)
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(ptr, bufSize, out length.GetPinnableReference(), label);
        }

        public static unsafe void GetObjectPtrLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(ptr, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(ptr, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel<T0>(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, length, label);
        }

        public static unsafe void GetObjectPtrLabel<T0>(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel<T0>(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel<T0>(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, out length.GetPinnableReference(), label);
        }

        public static unsafe void GetObjectPtrLabel<T0>(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel<T0>(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void ObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ObjectLabel(identifier, name, length, in label.GetPinnableReference());
        }

        public static unsafe void ObjectLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ObjectIdentifier identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ObjectLabel(identifier, name, length, in label.GetPinnableReference());
        }

        public static unsafe void ObjectPtrLabel(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ObjectPtrLabel(ptr, length, in label.GetPinnableReference());
        }

        public static unsafe void ObjectPtrLabel<T0>(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ObjectPtrLabel(in ptr.GetPinnableReference(), length, label);
        }

        public static unsafe void ObjectPtrLabel<T0>(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ObjectPtrLabel(in ptr.GetPinnableReference(), length, in label.GetPinnableReference());
        }

        public static unsafe void ObjectPtrLabel<T0>(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ObjectPtrLabel(in ptr.GetPinnableReference(), length, label);
        }

        public static unsafe void PushDebugGroup(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.PushDebugGroup(source, id, length, in message.GetPinnableReference());
        }

        public static unsafe void PushDebugGroup(this KhrDebug thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.PushDebugGroup(source, id, length, in message.GetPinnableReference());
        }

    }
}

