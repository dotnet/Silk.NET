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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbDebugOutputOverloads
    {
        public static unsafe void DebugMessageCallback<T0>(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcArb callback, [Count(Computed = "callback"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> userParam) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DebugMessageCallback(callback, in userParam.GetPinnableReference());
        }

        public static unsafe void DebugMessageControl(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageInsert(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSource source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this ArbDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

    }
}

