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

namespace Silk.NET.Vulkan.Extensions.AMDX
{
    public static class AmdxShaderEnqueueOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdDispatchGraph(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong scratch, [Count(Count = 0)] ulong scratchSize, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DispatchGraphCountInfoAMDX> pCountInfo)
        {
            // SpanOverloader
            thisApi.CmdDispatchGraph(commandBuffer, scratch, scratchSize, in pCountInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdDispatchGraphIndirect(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong scratch, [Count(Count = 0)] ulong scratchSize, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DispatchGraphCountInfoAMDX> pCountInfo)
        {
            // SpanOverloader
            thisApi.CmdDispatchGraphIndirect(commandBuffer, scratch, scratchSize, in pCountInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExecutionGraphPipelines(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateExecutionGraphPipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExecutionGraphPipelines(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateExecutionGraphPipelines(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExecutionGraphPipelines(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateExecutionGraphPipelines(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExecutionGraphPipelines(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExecutionGraphPipelineCreateInfoAMDX> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateExecutionGraphPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExecutionGraphPipelines(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExecutionGraphPipelineCreateInfoAMDX> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateExecutionGraphPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExecutionGraphPipelines(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExecutionGraphPipelineCreateInfoAMDX> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateExecutionGraphPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExecutionGraphPipelines(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExecutionGraphPipelineCreateInfoAMDX> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateExecutionGraphPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetExecutionGraphPipelineNodeIndex(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineShaderStageNodeCreateInfoAMDX* pNodeInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pNodeIndex)
        {
            // SpanOverloader
            return thisApi.GetExecutionGraphPipelineNodeIndex(device, executionGraph, pNodeInfo, out pNodeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetExecutionGraphPipelineNodeIndex(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineShaderStageNodeCreateInfoAMDX> pNodeInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pNodeIndex)
        {
            // SpanOverloader
            return thisApi.GetExecutionGraphPipelineNodeIndex(device, executionGraph, in pNodeInfo.GetPinnableReference(), pNodeIndex);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetExecutionGraphPipelineNodeIndex(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineShaderStageNodeCreateInfoAMDX> pNodeInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pNodeIndex)
        {
            // SpanOverloader
            return thisApi.GetExecutionGraphPipelineNodeIndex(device, executionGraph, in pNodeInfo.GetPinnableReference(), out pNodeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.ExecutionGraphPipelineScratchSizeAmdx);")]
        public static unsafe Result GetExecutionGraphPipelineScratchSize(this AmdxShaderEnqueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExecutionGraphPipelineScratchSizeAMDX> pSizeInfo)
        {
            // SpanOverloader
            return thisApi.GetExecutionGraphPipelineScratchSize(device, executionGraph, out pSizeInfo.GetPinnableReference());
        }

    }
}

