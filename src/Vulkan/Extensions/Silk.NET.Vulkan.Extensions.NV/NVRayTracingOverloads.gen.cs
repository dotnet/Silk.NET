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
    public static class NVRayTracingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result BindAccelerationStructureMemory(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindAccelerationStructureMemoryInfoNV> pBindInfos)
        {
            // SpanOverloader
            return thisApi.BindAccelerationStructureMemory(device, bindInfoCount, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructure(this NVRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureInfoNV> pInfo, [Count(Count = 0)] Buffer instanceData, [Count(Count = 0)] ulong instanceOffset, [Count(Count = 0)] Bool32 update, [Count(Count = 0)] AccelerationStructureNV dst, [Count(Count = 0)] AccelerationStructureNV src, [Count(Count = 0)] Buffer scratch, [Count(Count = 0)] ulong scratchOffset)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructure(commandBuffer, in pInfo.GetPinnableReference(), instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWriteAccelerationStructuresProperties(this NVRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureNV> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery)
        {
            // SpanOverloader
            thisApi.CmdWriteAccelerationStructuresProperties(commandBuffer, accelerationStructureCount, in pAccelerationStructures.GetPinnableReference(), queryType, queryPool, firstQuery);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureNV> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, pCreateInfo, pAllocator, out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureNV* pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, pCreateInfo, in pAllocator.GetPinnableReference(), pAccelerationStructure);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureNV> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureNV* pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), pAllocator, pAccelerationStructure);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureNV> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureNV* pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pAccelerationStructure);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureNV> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] RayTracingPipelineCreateInfoNV* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] RayTracingPipelineCreateInfoNV* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] RayTracingPipelineCreateInfoNV* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoNV> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoNV> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoNV> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoNV> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyAccelerationStructure(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureNV accelerationStructure, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyAccelerationStructure(device, accelerationStructure, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAccelerationStructureHandle<T0>(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureNV accelerationStructure, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetAccelerationStructureHandle(device, accelerationStructure, dataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetAccelerationStructureMemoryRequirements(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureMemoryRequirementsInfoNV* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2KHR> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureMemoryRequirements(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetAccelerationStructureMemoryRequirements(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureMemoryRequirementsInfoNV> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2KHR* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureMemoryRequirements(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetAccelerationStructureMemoryRequirements(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureMemoryRequirementsInfoNV> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2KHR> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureMemoryRequirements(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRayTracingShaderGroupHandles<T0>(this NVRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, dataSize, ref pData.GetPinnableReference());
        }

    }
}

