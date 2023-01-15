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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrSynchronization2Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdPipelineBarrier2(this KhrSynchronization2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DependencyInfo> pDependencyInfo)
        {
            // SpanOverloader
            thisApi.CmdPipelineBarrier2(commandBuffer, in pDependencyInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetEvent2(this KhrSynchronization2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DependencyInfo> pDependencyInfo)
        {
            // SpanOverloader
            thisApi.CmdSetEvent2(commandBuffer, @event, in pDependencyInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents2(this KhrSynchronization2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<DependencyInfo> pDependencyInfos)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents2(commandBuffer, eventCount, pEvents, in pDependencyInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents2(this KhrSynchronization2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] DependencyInfo* pDependencyInfos)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents2(commandBuffer, eventCount, in pEvents.GetPinnableReference(), pDependencyInfos);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWaitEvents2(this KhrSynchronization2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<DependencyInfo> pDependencyInfos)
        {
            // SpanOverloader
            thisApi.CmdWaitEvents2(commandBuffer, eventCount, in pEvents.GetPinnableReference(), in pDependencyInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointData2NV);")]
        public static unsafe void GetQueueCheckpointData2(this KhrSynchronization2 thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(FlowDirection.Out)] Span<CheckpointData2NV> pCheckpointData)
        {
            // SpanOverloader
            thisApi.GetQueueCheckpointData2(queue, pCheckpointDataCount, out pCheckpointData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetQueueCheckpointData2(this KhrSynchronization2 thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] Span<uint> pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(FlowDirection.Out)] CheckpointData2NV* pCheckpointData)
        {
            // SpanOverloader
            thisApi.GetQueueCheckpointData2(queue, ref pCheckpointDataCount.GetPinnableReference(), pCheckpointData);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointData2NV);")]
        public static unsafe void GetQueueCheckpointData2(this KhrSynchronization2 thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] Span<uint> pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(FlowDirection.Out)] Span<CheckpointData2NV> pCheckpointData)
        {
            // SpanOverloader
            thisApi.GetQueueCheckpointData2(queue, ref pCheckpointDataCount.GetPinnableReference(), out pCheckpointData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueueSubmit2(this KhrSynchronization2 thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Parameter = "submitCount"), Flow(FlowDirection.In)] ReadOnlySpan<SubmitInfo2> pSubmits, [Count(Count = 0)] Fence fence)
        {
            // SpanOverloader
            return thisApi.QueueSubmit2(queue, submitCount, in pSubmits.GetPinnableReference(), fence);
        }

    }
}

