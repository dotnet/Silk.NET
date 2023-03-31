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

namespace Silk.NET.OpenGLES
{
    public static class GLOverloads
    {
        public static unsafe void DebugMessageCallback<T0>(this GL thisApi, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] ReadOnlySpan<T0> userParam) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DebugMessageCallback(callback, in userParam.GetPinnableReference());
        }

        public static unsafe void DebugMessageControl(this GL thisApi, [Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this GL thisApi, [Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this GL thisApi, [Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this GL thisApi, [Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this GL thisApi, [Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this GL thisApi, [Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this GL thisApi, [Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageControl(this GL thisApi, [Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageControl(source, type, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageInsert(this GL thisApi, [Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this GL thisApi, [Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this GL thisApi, [Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this GL thisApi, [Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this GL thisApi, [Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this GL thisApi, [Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this GL thisApi, [Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this GL thisApi, [Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(source, type, id, severity, length, in buf.GetPinnableReference());
        }

        public static unsafe void DrawElementsBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsBaseVertex(mode, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawElementsBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsBaseVertex(mode, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawElementsBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsBaseVertex(mode, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawElementsBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsBaseVertex(mode, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertex(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertex(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertex(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertex(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, sources, out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), types, out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), ids, out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), severities, out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), lengths, out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), messageLog);
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> messageLog)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out sources.GetPinnableReference(), out types.GetPinnableReference(), out ids.GetPinnableReference(), out severities.GetPinnableReference(), out lengths.GetPinnableReference(), out messageLog.GetPinnableReference());
        }

        public static unsafe void GetnUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void GetnUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void GetnUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), label);
        }

        public static unsafe void GetObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), label);
        }

        public static unsafe void GetObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(identifier, name, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel(this GL thisApi, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(ptr, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel(this GL thisApi, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(ptr, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel(this GL thisApi, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label)
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(ptr, bufSize, out length.GetPinnableReference(), label);
        }

        public static unsafe void GetObjectPtrLabel(this GL thisApi, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(ptr, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel(this GL thisApi, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(ptr, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel<T0>(this GL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, length, label);
        }

        public static unsafe void GetObjectPtrLabel<T0>(this GL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel<T0>(this GL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel<T0>(this GL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, out length.GetPinnableReference(), label);
        }

        public static unsafe void GetObjectPtrLabel<T0>(this GL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectPtrLabel<T0>(this GL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetObjectPtrLabel(in ptr.GetPinnableReference(), bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ObjectLabel(identifier, name, length, in label.GetPinnableReference());
        }

        public static unsafe void ObjectLabel(this GL thisApi, [Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ObjectLabel(identifier, name, length, in label.GetPinnableReference());
        }

        public static unsafe void ObjectPtrLabel(this GL thisApi, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ObjectPtrLabel(ptr, length, in label.GetPinnableReference());
        }

        public static unsafe void ObjectPtrLabel<T0>(this GL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] byte* label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ObjectPtrLabel(in ptr.GetPinnableReference(), length, label);
        }

        public static unsafe void ObjectPtrLabel<T0>(this GL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ObjectPtrLabel(in ptr.GetPinnableReference(), length, in label.GetPinnableReference());
        }

        public static unsafe void ObjectPtrLabel<T0>(this GL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ObjectPtrLabel(in ptr.GetPinnableReference(), length, label);
        }

        public static unsafe void PushDebugGroup(this GL thisApi, [Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.PushDebugGroup(source, id, length, in message.GetPinnableReference());
        }

        public static unsafe void PushDebugGroup(this GL thisApi, [Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.PushDebugGroup(source, id, length, in message.GetPinnableReference());
        }

        public static unsafe void ReadnPixels<T0>(this GL thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, out data.GetPinnableReference());
        }

        public static unsafe void ReadnPixels<T0>(this GL thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, out data.GetPinnableReference());
        }

        public static unsafe void ReadnPixels<T0>(this GL thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, out data.GetPinnableReference());
        }

        public static unsafe void ReadnPixels<T0>(this GL thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, out data.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void DeleteProgramPipelines(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> pipelines)
        {
            // SpanOverloader
            thisApi.DeleteProgramPipelines(n, in pipelines.GetPinnableReference());
        }

        public static unsafe void DeleteProgramPipelines(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramPipeline> pipelines)
        {
            // SpanOverloader
            thisApi.DeleteProgramPipelines(n, in pipelines.GetPinnableReference());
        }

        public static unsafe void DrawArraysIndirect<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawArraysIndirect(mode, in indirect.GetPinnableReference());
        }

        public static unsafe void DrawArraysIndirect<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawArraysIndirect(mode, in indirect.GetPinnableReference());
        }

        public static unsafe void DrawElementsIndirect<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsIndirect(mode, type, in indirect.GetPinnableReference());
        }

        public static unsafe void DrawElementsIndirect<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsIndirect(mode, type, in indirect.GetPinnableReference());
        }

        public static unsafe void DrawElementsIndirect<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsIndirect(mode, type, in indirect.GetPinnableReference());
        }

        public static unsafe void DrawElementsIndirect<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsIndirect(mode, type, in indirect.GetPinnableReference());
        }

        public static unsafe void GenProgramPipelines(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines)
        {
            // SpanOverloader
            thisApi.GenProgramPipelines(n, out pipelines.GetPinnableReference());
        }

        public static unsafe void GenProgramPipelines(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<ProgramPipeline> pipelines)
        {
            // SpanOverloader
            thisApi.GenProgramPipelines(n, out pipelines.GetPinnableReference());
        }

        public static unsafe void GetBoolean(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetBoolean(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetBoolean(this GL thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetBoolean(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this GL thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this GL thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultisample(this GL thisApi, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> val)
        {
            // SpanOverloader
            thisApi.GetMultisample(pname, index, out val.GetPinnableReference());
        }

        public static unsafe void GetMultisample(this GL thisApi, [Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> val)
        {
            // SpanOverloader
            thisApi.GetMultisample(pname, index, out val.GetPinnableReference());
        }

        public static unsafe void GetProgramInterface(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramInterface(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramInterface(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramInterface(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramPipeline(this GL thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramPipeline(pipeline, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramPipeline(this GL thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramPipeline(pipeline, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramPipelineInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramPipelineInfoLog(pipeline, bufSize, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetProgramPipelineInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramPipelineInfoLog(pipeline, bufSize, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetProgramPipelineInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramPipelineInfoLog(pipeline, bufSize, out length.GetPinnableReference(), infoLog);
        }

        public static unsafe void GetProgramPipelineInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramPipelineInfoLog(pipeline, bufSize, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetProgramPipelineInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramPipelineInfoLog(pipeline, bufSize, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe uint GetProgramResourceIndex(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe uint GetProgramResourceIndex(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocation(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocation(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocation(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocation(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetProgramResourceName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetProgramResourceName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameter(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameter(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameter(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameter(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameter(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameter(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameter(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameter(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x3(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x4(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x2(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x4(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x2(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x3(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ClearBuffer(this GL thisApi, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ClearBuffer(buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void ClearBuffer(this GL thisApi, [Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ClearBuffer(buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void ClearBuffer(this GL thisApi, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ClearBuffer(buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void ClearBuffer(this GL thisApi, [Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ClearBuffer(buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void ClearBuffer(this GL thisApi, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ClearBuffer(buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void ClearBuffer(this GL thisApi, [Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ClearBuffer(buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void DeleteQueries(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids)
        {
            // SpanOverloader
            thisApi.DeleteQueries(n, in ids.GetPinnableReference());
        }

        public static unsafe void DeleteQueries(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Query> ids)
        {
            // SpanOverloader
            thisApi.DeleteQueries(n, in ids.GetPinnableReference());
        }

        public static unsafe void DeleteSamplers(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> samplers)
        {
            // SpanOverloader
            thisApi.DeleteSamplers(count, in samplers.GetPinnableReference());
        }

        public static unsafe void DeleteSamplers(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Sampler> samplers)
        {
            // SpanOverloader
            thisApi.DeleteSamplers(count, in samplers.GetPinnableReference());
        }

        public static unsafe void DeleteTransformFeedbacks(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids)
        {
            // SpanOverloader
            thisApi.DeleteTransformFeedbacks(n, in ids.GetPinnableReference());
        }

        public static unsafe void DeleteTransformFeedbacks(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<TransformFeedback> ids)
        {
            // SpanOverloader
            thisApi.DeleteTransformFeedbacks(n, in ids.GetPinnableReference());
        }

        public static unsafe void DeleteVertexArrays(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> arrays)
        {
            // SpanOverloader
            thisApi.DeleteVertexArrays(n, in arrays.GetPinnableReference());
        }

        public static unsafe void DeleteVertexArrays(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<VertexArray> arrays)
        {
            // SpanOverloader
            thisApi.DeleteVertexArrays(n, in arrays.GetPinnableReference());
        }

        public static unsafe void DrawBuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> bufs)
        {
            // SpanOverloader
            thisApi.DrawBuffers(n, in bufs.GetPinnableReference());
        }

        public static unsafe void DrawBuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<DrawBufferMode> bufs)
        {
            // SpanOverloader
            thisApi.DrawBuffers(n, in bufs.GetPinnableReference());
        }

        public static unsafe void DrawElementsInstanced<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), instancecount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), instancecount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), instancecount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), instancecount);
        }

        public static unsafe void DrawRangeElements<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElements(mode, start, end, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void DrawRangeElements<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElements(mode, start, end, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void DrawRangeElements<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElements(mode, start, end, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void DrawRangeElements<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElements(mode, start, end, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void GenQueries(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
        {
            // SpanOverloader
            thisApi.GenQueries(n, out ids.GetPinnableReference());
        }

        public static unsafe void GenQueries(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Query> ids)
        {
            // SpanOverloader
            thisApi.GenQueries(n, out ids.GetPinnableReference());
        }

        public static unsafe void GenSamplers(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> samplers)
        {
            // SpanOverloader
            thisApi.GenSamplers(count, out samplers.GetPinnableReference());
        }

        public static unsafe void GenSamplers(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<Sampler> samplers)
        {
            // SpanOverloader
            thisApi.GenSamplers(count, out samplers.GetPinnableReference());
        }

        public static unsafe void GenTransformFeedbacks(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
        {
            // SpanOverloader
            thisApi.GenTransformFeedbacks(n, out ids.GetPinnableReference());
        }

        public static unsafe void GenTransformFeedbacks(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<TransformFeedback> ids)
        {
            // SpanOverloader
            thisApi.GenTransformFeedbacks(n, out ids.GetPinnableReference());
        }

        public static unsafe void GenVertexArrays(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays)
        {
            // SpanOverloader
            thisApi.GenVertexArrays(n, out arrays.GetPinnableReference());
        }

        public static unsafe void GenVertexArrays(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<VertexArray> arrays)
        {
            // SpanOverloader
            thisApi.GenVertexArrays(n, out arrays.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlock(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlock(program, uniformBlockIndex, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlock(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlock(program, uniformBlockIndex, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length.GetPinnableReference(), uniformBlockName);
        }

        public static unsafe void GetActiveUniformBlockName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length.GetPinnableReference(), out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length.GetPinnableReference(), out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, uniformIndices, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, @params);
        }

        public static unsafe void GetActiveUniforms(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, uniformIndices, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, @params);
        }

        public static unsafe void GetActiveUniforms(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this GL thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this GL thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe int GetFragDataLocation(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetFragDataLocation(program, in name.GetPinnableReference());
        }

        public static unsafe void GetInteger(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInteger(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetInteger(this GL thisApi, [Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInteger(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetInteger64(this GL thisApi, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> data)
        {
            // SpanOverloader
            thisApi.GetInteger64(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetInteger64(this GL thisApi, [Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> data)
        {
            // SpanOverloader
            thisApi.GetInteger64(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetInteger64(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<long> data)
        {
            // SpanOverloader
            thisApi.GetInteger64(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetInteger64(this GL thisApi, [Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<long> data)
        {
            // SpanOverloader
            thisApi.GetInteger64(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, length, binaryFormat, out binary.GetPinnableReference());
        }

        public static unsafe void GetProgramBinary(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary)
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, length, out binaryFormat.GetPinnableReference(), binary);
        }

        public static unsafe void GetProgramBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, length, out binaryFormat.GetPinnableReference(), out binary.GetPinnableReference());
        }

        public static unsafe void GetProgramBinary(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary)
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, out length.GetPinnableReference(), binaryFormat, binary);
        }

        public static unsafe void GetProgramBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, out length.GetPinnableReference(), binaryFormat, out binary.GetPinnableReference());
        }

        public static unsafe void GetProgramBinary(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary)
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, out length.GetPinnableReference(), out binaryFormat.GetPinnableReference(), binary);
        }

        public static unsafe void GetProgramBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, out length.GetPinnableReference(), out binaryFormat.GetPinnableReference(), out binary.GetPinnableReference());
        }

        public static unsafe void GetQuery(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetQuery(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQuery(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetQuery(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQuery(this GL thisApi, [Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetQuery(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQuery(this GL thisApi, [Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetQuery(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQueryObject(this GL thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetQueryObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQueryObject(this GL thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetQueryObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSync(this GL thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, length, out values.GetPinnableReference());
        }

        public static unsafe void GetSync(this GL thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), values);
        }

        public static unsafe void GetSync(this GL thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), out values.GetPinnableReference());
        }

        public static unsafe void GetSync(this GL thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, length, out values.GetPinnableReference());
        }

        public static unsafe void GetSync(this GL thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), values);
        }

        public static unsafe void GetSync(this GL thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), out values.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(program, location, out @params.GetPinnableReference());
        }

        public static unsafe uint GetUniformBlockIndex(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<byte> uniformBlockName)
        {
            // SpanOverloader
            return thisApi.GetUniformBlockIndex(program, in uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetUniformIndices(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] Span<uint> uniformIndices)
        {
            // SpanOverloader
            thisApi.GetUniformIndices(program, uniformCount, uniformNames, out uniformIndices.GetPinnableReference());
        }

        public static unsafe void GetUniformIndices(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] in byte* uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] Span<uint> uniformIndices)
        {
            // SpanOverloader
            thisApi.GetUniformIndices(program, uniformCount, in uniformNames, out uniformIndices.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void InvalidateFramebuffer(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> attachments)
        {
            // SpanOverloader
            thisApi.InvalidateFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void InvalidateFramebuffer(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            // SpanOverloader
            thisApi.InvalidateFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void InvalidateFramebuffer(this GL thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> attachments)
        {
            // SpanOverloader
            thisApi.InvalidateFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void InvalidateFramebuffer(this GL thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            // SpanOverloader
            thisApi.InvalidateFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void InvalidateSubFramebuffer(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
        {
            // SpanOverloader
            thisApi.InvalidateSubFramebuffer(target, numAttachments, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public static unsafe void InvalidateSubFramebuffer(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
        {
            // SpanOverloader
            thisApi.InvalidateSubFramebuffer(target, numAttachments, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public static unsafe void InvalidateSubFramebuffer(this GL thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<GLEnum> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
        {
            // SpanOverloader
            thisApi.InvalidateSubFramebuffer(target, numAttachments, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public static unsafe void InvalidateSubFramebuffer(this GL thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
        {
            // SpanOverloader
            thisApi.InvalidateSubFramebuffer(target, numAttachments, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public static unsafe void ProgramBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ProgramBinary(program, binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void SamplerParameter(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this GL thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void Uniform1(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix2x3(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix2x3(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix2x4(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix2x4(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix3x2(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix3x2(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix3x4(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix3x4(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix4x2(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix4x2(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix4x3(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix4x3(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void BindAttribLocation(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.BindAttribLocation(program, index, in name.GetPinnableReference());
        }

        public static unsafe void BufferData<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferData(target, size, in data.GetPinnableReference(), usage);
        }

        public static unsafe void BufferData<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferData(target, size, in data.GetPinnableReference(), usage);
        }

        public static unsafe void BufferData<T0>(this GL thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferData(target, size, in data.GetPinnableReference(), usage);
        }

        public static unsafe void BufferData<T0>(this GL thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferData(target, size, in data.GetPinnableReference(), usage);
        }

        public static unsafe void BufferSubData<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferSubData(target, offset, size, in data.GetPinnableReference());
        }

        public static unsafe void BufferSubData<T0>(this GL thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferSubData(target, offset, size, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void DeleteBuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers)
        {
            // SpanOverloader
            thisApi.DeleteBuffers(n, in buffers.GetPinnableReference());
        }

        public static unsafe void DeleteBuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers)
        {
            // SpanOverloader
            thisApi.DeleteBuffers(n, in buffers.GetPinnableReference());
        }

        public static unsafe void DeleteFramebuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> framebuffers)
        {
            // SpanOverloader
            thisApi.DeleteFramebuffers(n, in framebuffers.GetPinnableReference());
        }

        public static unsafe void DeleteFramebuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Framebuffer> framebuffers)
        {
            // SpanOverloader
            thisApi.DeleteFramebuffers(n, in framebuffers.GetPinnableReference());
        }

        public static unsafe void DeleteRenderbuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> renderbuffers)
        {
            // SpanOverloader
            thisApi.DeleteRenderbuffers(n, in renderbuffers.GetPinnableReference());
        }

        public static unsafe void DeleteRenderbuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Renderbuffer> renderbuffers)
        {
            // SpanOverloader
            thisApi.DeleteRenderbuffers(n, in renderbuffers.GetPinnableReference());
        }

        public static unsafe void DeleteTextures(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures)
        {
            // SpanOverloader
            thisApi.DeleteTextures(n, in textures.GetPinnableReference());
        }

        public static unsafe void DeleteTextures(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures)
        {
            // SpanOverloader
            thisApi.DeleteTextures(n, in textures.GetPinnableReference());
        }

        public static unsafe void DrawElements<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElements(mode, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void DrawElements<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElements(mode, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void DrawElements<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElements(mode, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void DrawElements<T0>(this GL thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElements(mode, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void GenBuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers)
        {
            // SpanOverloader
            thisApi.GenBuffers(n, out buffers.GetPinnableReference());
        }

        public static unsafe void GenBuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Buffer> buffers)
        {
            // SpanOverloader
            thisApi.GenBuffers(n, out buffers.GetPinnableReference());
        }

        public static unsafe void GenFramebuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers)
        {
            // SpanOverloader
            thisApi.GenFramebuffers(n, out framebuffers.GetPinnableReference());
        }

        public static unsafe void GenFramebuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Framebuffer> framebuffers)
        {
            // SpanOverloader
            thisApi.GenFramebuffers(n, out framebuffers.GetPinnableReference());
        }

        public static unsafe void GenRenderbuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers)
        {
            // SpanOverloader
            thisApi.GenRenderbuffers(n, out renderbuffers.GetPinnableReference());
        }

        public static unsafe void GenRenderbuffers(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Renderbuffer> renderbuffers)
        {
            // SpanOverloader
            thisApi.GenRenderbuffers(n, out renderbuffers.GetPinnableReference());
        }

        public static unsafe void GenTextures(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures)
        {
            // SpanOverloader
            thisApi.GenTextures(n, out textures.GetPinnableReference());
        }

        public static unsafe void GenTextures(this GL thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Texture> textures)
        {
            // SpanOverloader
            thisApi.GenTextures(n, out textures.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<GLEnum> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetAttachedShaders(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> shaders)
        {
            // SpanOverloader
            thisApi.GetAttachedShaders(program, maxCount, count, out shaders.GetPinnableReference());
        }

        public static unsafe void GetAttachedShaders(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* shaders)
        {
            // SpanOverloader
            thisApi.GetAttachedShaders(program, maxCount, out count.GetPinnableReference(), shaders);
        }

        public static unsafe void GetAttachedShaders(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> shaders)
        {
            // SpanOverloader
            thisApi.GetAttachedShaders(program, maxCount, out count.GetPinnableReference(), out shaders.GetPinnableReference());
        }

        public static unsafe void GetAttachedShaders(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<Shader> shaders)
        {
            // SpanOverloader
            thisApi.GetAttachedShaders(program, maxCount, count, out shaders.GetPinnableReference());
        }

        public static unsafe void GetAttachedShaders(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Shader* shaders)
        {
            // SpanOverloader
            thisApi.GetAttachedShaders(program, maxCount, out count.GetPinnableReference(), shaders);
        }

        public static unsafe void GetAttachedShaders(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<Shader> shaders)
        {
            // SpanOverloader
            thisApi.GetAttachedShaders(program, maxCount, out count.GetPinnableReference(), out shaders.GetPinnableReference());
        }

        public static unsafe int GetAttribLocation(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetAttribLocation(program, in name.GetPinnableReference());
        }

        public static unsafe void GetBoolean(this GL thisApi, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetBoolean(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetBoolean(this GL thisApi, [Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetBoolean(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this GL thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this GL thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFloat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetFloat(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetFloat(this GL thisApi, [Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetFloat(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this GL thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this GL thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this GL thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this GL thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetInteger(this GL thisApi, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInteger(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetInteger(this GL thisApi, [Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInteger(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetProgram(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(program, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgram(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(program, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramInfoLog(program, bufSize, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetProgramInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramInfoLog(program, bufSize, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetProgramInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramInfoLog(program, bufSize, out length.GetPinnableReference(), infoLog);
        }

        public static unsafe void GetProgramInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramInfoLog(program, bufSize, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetProgramInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramInfoLog(program, bufSize, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetRenderbufferParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetRenderbufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetRenderbufferParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetRenderbufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetRenderbufferParameter(this GL thisApi, [Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetRenderbufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetRenderbufferParameter(this GL thisApi, [Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetRenderbufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetShader(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetShader(shader, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetShader(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetShader(shader, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetShaderInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog)
        {
            // SpanOverloader
            thisApi.GetShaderInfoLog(shader, bufSize, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetShaderInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetShaderInfoLog(shader, bufSize, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetShaderInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog)
        {
            // SpanOverloader
            thisApi.GetShaderInfoLog(shader, bufSize, out length.GetPinnableReference(), infoLog);
        }

        public static unsafe void GetShaderInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog)
        {
            // SpanOverloader
            thisApi.GetShaderInfoLog(shader, bufSize, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetShaderInfoLog(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetShaderInfoLog(shader, bufSize, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, range, out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), precision);
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, range, out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), precision);
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, range, out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), precision);
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, range, out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), precision);
        }

        public static unsafe void GetShaderPrecisionFormat(this GL thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(shader, bufSize, length, out source.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(shader, bufSize, length, out source.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(shader, bufSize, out length.GetPinnableReference(), source);
        }

        public static unsafe void GetShaderSource(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(shader, bufSize, out length.GetPinnableReference(), out source.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(shader, bufSize, out length.GetPinnableReference(), out source.GetPinnableReference());
        }

        public static unsafe void GetTexParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(program, location, out @params.GetPinnableReference());
        }

        public static unsafe void GetUniform(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(program, location, out @params.GetPinnableReference());
        }

        public static unsafe int GetUniformLocation(this GL thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetUniformLocation(program, in name.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ReadPixels<T0>(this GL thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadPixels(x, y, width, height, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void ReadPixels<T0>(this GL thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadPixels(x, y, width, height, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void ReadPixels<T0>(this GL thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadPixels(x, y, width, height, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void ReadPixels<T0>(this GL thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadPixels(x, y, width, height, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void ShaderBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public static unsafe void ShaderBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public static unsafe void ShaderBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public static unsafe void ShaderBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public static unsafe void ShaderBinary<T0>(this GL thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderSource(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // SpanOverloader
            thisApi.ShaderSource(shader, count, @string, in length.GetPinnableReference());
        }

        public static unsafe void ShaderSource(this GL thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // SpanOverloader
            thisApi.ShaderSource(shader, count, in @string, in length.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage2D(target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.TexParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.TexParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.TexParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.TexParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameter(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameter(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage2D<T0>(this GL thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void Uniform1(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform1(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix2(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix2(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix3(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix3(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix4(this GL thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix4(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this GL thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

    }
}

