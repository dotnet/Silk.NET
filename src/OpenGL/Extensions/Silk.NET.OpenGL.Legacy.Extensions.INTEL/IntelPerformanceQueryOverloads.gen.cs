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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    public static class IntelPerformanceQueryOverloads
    {
        public static unsafe void CreatePerfQuery(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> queryHandle)
        {
            // SpanOverloader
            thisApi.CreatePerfQuery(queryId, out queryHandle.GetPinnableReference());
        }

        public static unsafe void CreatePerfQuery(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerfQueryHandle> queryHandle)
        {
            // SpanOverloader
            thisApi.CreatePerfQuery(queryId, out queryHandle.GetPinnableReference());
        }

        public static unsafe void GetFirstPerfQueryId(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> queryId)
        {
            // SpanOverloader
            thisApi.GetFirstPerfQueryId(out queryId.GetPinnableReference());
        }

        public static unsafe void GetFirstPerfQueryId(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerfQueryId> queryId)
        {
            // SpanOverloader
            thisApi.GetFirstPerfQueryId(out queryId.GetPinnableReference());
        }

        public static unsafe void GetNextPerfQueryId(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> nextQueryId)
        {
            // SpanOverloader
            thisApi.GetNextPerfQueryId(queryId, out nextQueryId.GetPinnableReference());
        }

        public static unsafe void GetNextPerfQueryId(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerfQueryId> nextQueryId)
        {
            // SpanOverloader
            thisApi.GetNextPerfQueryId(queryId, out nextQueryId.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), counterDataSize, out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), counterTypeEnum, out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), counterDataTypeEnum, out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), rawCounterMaxValue);
        }

        public static unsafe void GetPerfCounterInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
        {
            // SpanOverloader
            thisApi.GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName.GetPinnableReference(), counterDescLength, out counterDesc.GetPinnableReference(), out counterOffset.GetPinnableReference(), out counterDataSize.GetPinnableReference(), out counterTypeEnum.GetPinnableReference(), out counterDataTypeEnum.GetPinnableReference(), out rawCounterMaxValue.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryData(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryHandle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> bytesWritten)
        {
            // SpanOverloader
            thisApi.GetPerfQueryData(queryHandle, flags, dataSize, data, out bytesWritten.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryData<T0>(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryHandle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* bytesWritten) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPerfQueryData(queryHandle, flags, dataSize, out data.GetPinnableReference(), bytesWritten);
        }

        public static unsafe void GetPerfQueryData<T0>(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryHandle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> bytesWritten) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPerfQueryData(queryHandle, flags, dataSize, out data.GetPinnableReference(), out bytesWritten.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryData(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryHandle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PerfQueryDataFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> bytesWritten)
        {
            // SpanOverloader
            thisApi.GetPerfQueryData(queryHandle, flags, dataSize, data, out bytesWritten.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryData<T0>(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryHandle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PerfQueryDataFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* bytesWritten) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPerfQueryData(queryHandle, flags, dataSize, out data.GetPinnableReference(), bytesWritten);
        }

        public static unsafe void GetPerfQueryData<T0>(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryHandle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PerfQueryDataFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> bytesWritten) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPerfQueryData(queryHandle, flags, dataSize, out data.GetPinnableReference(), out bytesWritten.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryIdByName(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> queryId)
        {
            // SpanOverloader
            thisApi.GetPerfQueryIdByName(queryName, out queryId.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryIdByName(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* queryId)
        {
            // SpanOverloader
            thisApi.GetPerfQueryIdByName(out queryName.GetPinnableReference(), queryId);
        }

        public static unsafe void GetPerfQueryIdByName(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> queryId)
        {
            // SpanOverloader
            thisApi.GetPerfQueryIdByName(out queryName.GetPinnableReference(), out queryId.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryIdByName(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> queryId)
        {
            // SpanOverloader
            thisApi.GetPerfQueryIdByName(queryName, out queryId.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryIdByName(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerfQueryId> queryId)
        {
            // SpanOverloader
            thisApi.GetPerfQueryIdByName(queryName, out queryId.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryIdByName(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerfQueryId* queryId)
        {
            // SpanOverloader
            thisApi.GetPerfQueryIdByName(out queryName.GetPinnableReference(), queryId);
        }

        public static unsafe void GetPerfQueryIdByName(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerfQueryId> queryId)
        {
            // SpanOverloader
            thisApi.GetPerfQueryIdByName(out queryName.GetPinnableReference(), out queryId.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryIdByName(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerfQueryId> queryId)
        {
            // SpanOverloader
            thisApi.GetPerfQueryIdByName(queryName, out queryId.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), noCounters, noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), noCounters, noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), dataSize, out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), noCounters, out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), noInstances, out capsMask.GetPinnableReference());
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), capsMask);
        }

        public static unsafe void GetPerfQueryInfo(this IntelPerformanceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PerformanceQueryCapsMaskINTEL> capsMask)
        {
            // SpanOverloader
            thisApi.GetPerfQueryInfo(queryId, queryNameLength, out queryName.GetPinnableReference(), out dataSize.GetPinnableReference(), out noCounters.GetPinnableReference(), out noInstances.GetPinnableReference(), out capsMask.GetPinnableReference());
        }

    }
}

