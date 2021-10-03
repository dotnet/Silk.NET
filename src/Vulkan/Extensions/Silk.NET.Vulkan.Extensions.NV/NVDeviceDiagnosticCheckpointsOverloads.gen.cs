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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVDeviceDiagnosticCheckpointsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetCheckpoint<T0>(this NVDeviceDiagnosticCheckpoints thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Span<T0> pCheckpointMarker) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CmdSetCheckpoint(commandBuffer, ref pCheckpointMarker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointDataNV);")]
        public static unsafe void GetQueueCheckpointData(this NVDeviceDiagnosticCheckpoints thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(FlowDirection.Out)] Span<CheckpointDataNV> pCheckpointData)
        {
            // SpanOverloader
            thisApi.GetQueueCheckpointData(queue, pCheckpointDataCount, out pCheckpointData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetQueueCheckpointData(this NVDeviceDiagnosticCheckpoints thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] Span<uint> pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(FlowDirection.Out)] CheckpointDataNV* pCheckpointData)
        {
            // SpanOverloader
            thisApi.GetQueueCheckpointData(queue, ref pCheckpointDataCount.GetPinnableReference(), pCheckpointData);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointDataNV);")]
        public static unsafe void GetQueueCheckpointData(this NVDeviceDiagnosticCheckpoints thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] Span<uint> pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(FlowDirection.Out)] Span<CheckpointDataNV> pCheckpointData)
        {
            // SpanOverloader
            thisApi.GetQueueCheckpointData(queue, ref pCheckpointDataCount.GetPinnableReference(), out pCheckpointData.GetPinnableReference());
        }

    }
}

