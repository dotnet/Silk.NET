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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.AMDX
{
    [Extension("VK_AMDX_shader_enqueue")]
    public unsafe partial class AmdxShaderEnqueue : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_AMDX_shader_enqueue";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchGraphAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDispatchGraph([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong scratch, [Count(Count = 0)] ulong scratchSize, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DispatchGraphCountInfoAMDX* pCountInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchGraphAMDX", Convention = CallingConvention.Winapi)]
        public partial void CmdDispatchGraph([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong scratch, [Count(Count = 0)] ulong scratchSize, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DispatchGraphCountInfoAMDX pCountInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchGraphIndirectAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDispatchGraphIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong scratch, [Count(Count = 0)] ulong scratchSize, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DispatchGraphCountInfoAMDX* pCountInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchGraphIndirectAMDX", Convention = CallingConvention.Winapi)]
        public partial void CmdDispatchGraphIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong scratch, [Count(Count = 0)] ulong scratchSize, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DispatchGraphCountInfoAMDX pCountInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchGraphIndirectCountAMDX", Convention = CallingConvention.Winapi)]
        public partial void CmdDispatchGraphIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong scratch, [Count(Count = 0)] ulong scratchSize, [Count(Count = 0)] ulong countInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdInitializeGraphScratchMemoryAMDX", Convention = CallingConvention.Winapi)]
        public partial void CmdInitializeGraphScratchMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0)] ulong scratch, [Count(Count = 0)] ulong scratchSize);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExecutionGraphPipelinesAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExecutionGraphPipelinesAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExecutionGraphPipelinesAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExecutionGraphPipelinesAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExecutionGraphPipelinesAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ExecutionGraphPipelineCreateInfoAMDX pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExecutionGraphPipelinesAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ExecutionGraphPipelineCreateInfoAMDX pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExecutionGraphPipelinesAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ExecutionGraphPipelineCreateInfoAMDX pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExecutionGraphPipelinesAMDX", Convention = CallingConvention.Winapi)]
        public partial Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ExecutionGraphPipelineCreateInfoAMDX pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetExecutionGraphPipelineNodeIndexAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetExecutionGraphPipelineNodeIndex([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineShaderStageNodeCreateInfoAMDX* pNodeInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pNodeIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetExecutionGraphPipelineNodeIndexAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetExecutionGraphPipelineNodeIndex([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineShaderStageNodeCreateInfoAMDX* pNodeInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pNodeIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetExecutionGraphPipelineNodeIndexAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetExecutionGraphPipelineNodeIndex([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineShaderStageNodeCreateInfoAMDX pNodeInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pNodeIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetExecutionGraphPipelineNodeIndexAMDX", Convention = CallingConvention.Winapi)]
        public partial Result GetExecutionGraphPipelineNodeIndex([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineShaderStageNodeCreateInfoAMDX pNodeInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pNodeIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetExecutionGraphPipelineScratchSizeAMDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetExecutionGraphPipelineScratchSize([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExecutionGraphPipelineScratchSizeAMDX* pSizeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.ExecutionGraphPipelineScratchSizeAmdx);")]
        [NativeApi(EntryPoint = "vkGetExecutionGraphPipelineScratchSizeAMDX", Convention = CallingConvention.Winapi)]
        public partial Result GetExecutionGraphPipelineScratchSize([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline executionGraph, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExecutionGraphPipelineScratchSizeAMDX pSizeInfo);

        /// <summary>To be documented.</summary>
        public unsafe Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateExecutionGraphPipelines(device, pipelineCache, (uint) pPipelines.Length, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateExecutionGraphPipelines(device, pipelineCache, (uint) pPipelines.Length, pCreateInfos, in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExecutionGraphPipelineCreateInfoAMDX> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateExecutionGraphPipelines(device, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExecutionGraphPipelineCreateInfoAMDX> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateExecutionGraphPipelines(device, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExecutionGraphPipelineCreateInfoAMDX> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateExecutionGraphPipelines(device, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateExecutionGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExecutionGraphPipelineCreateInfoAMDX> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateExecutionGraphPipelines(device, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, out pPipelines.GetPinnableReference());
        }

        public AmdxShaderEnqueue(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

