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

namespace Silk.NET.Vulkan.Extensions.ARM
{
    public static class ArmDataGraphOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result BindDataGraphPipelineSessionMemory(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindDataGraphPipelineSessionMemoryInfoARM> pBindInfos)
        {
            // SpanOverloader
            return thisApi.BindDataGraphPipelineSessionMemory(device, bindInfoCount, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdDispatchDataGraph(this ArmDataGraph thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DataGraphPipelineSessionARM session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineDispatchInfoARM> pInfo)
        {
            // SpanOverloader
            thisApi.CmdDispatchDataGraph(commandBuffer, session, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelines(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineCreateInfoARM* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelines(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelines(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineCreateInfoARM* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelines(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelines(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineCreateInfoARM* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelines(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelines(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineCreateInfoARM> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelines(device, deferredOperation, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelines(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineCreateInfoARM> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelines(device, deferredOperation, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelines(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineCreateInfoARM> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelines(device, deferredOperation, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelines(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineCreateInfoARM> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelines(device, deferredOperation, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelineSession(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelineSessionARM> pSession)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelineSession(device, pCreateInfo, pAllocator, out pSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelineSession(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionARM* pSession)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelineSession(device, pCreateInfo, in pAllocator.GetPinnableReference(), pSession);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelineSession(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelineSessionARM> pSession)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelineSession(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelineSession(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineSessionCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionARM* pSession)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelineSession(device, in pCreateInfo.GetPinnableReference(), pAllocator, pSession);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelineSession(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineSessionCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelineSessionARM> pSession)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelineSession(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelineSession(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineSessionCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionARM* pSession)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelineSession(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSession);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDataGraphPipelineSession(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineSessionCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelineSessionARM> pSession)
        {
            // SpanOverloader
            return thisApi.CreateDataGraphPipelineSession(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyDataGraphPipelineSession(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DataGraphPipelineSessionARM session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyDataGraphPipelineSession(device, session, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineAvailableProperties(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Count = 0)] uint* pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelinePropertyARM> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineAvailableProperties(device, pPipelineInfo, pPropertiesCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineAvailableProperties(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Count = 0)] Span<uint> pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelinePropertyARM* pProperties)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineAvailableProperties(device, pPipelineInfo, ref pPropertiesCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineAvailableProperties(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Count = 0)] Span<uint> pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelinePropertyARM> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineAvailableProperties(device, pPipelineInfo, ref pPropertiesCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineAvailableProperties(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineInfoARM> pPipelineInfo, [Count(Count = 0)] uint* pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelinePropertyARM* pProperties)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineAvailableProperties(device, in pPipelineInfo.GetPinnableReference(), pPropertiesCount, pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineAvailableProperties(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineInfoARM> pPipelineInfo, [Count(Count = 0)] uint* pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelinePropertyARM> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineAvailableProperties(device, in pPipelineInfo.GetPinnableReference(), pPropertiesCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineAvailableProperties(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineInfoARM> pPipelineInfo, [Count(Count = 0)] Span<uint> pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelinePropertyARM* pProperties)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineAvailableProperties(device, in pPipelineInfo.GetPinnableReference(), ref pPropertiesCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineAvailableProperties(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineInfoARM> pPipelineInfo, [Count(Count = 0)] Span<uint> pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelinePropertyARM> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineAvailableProperties(device, in pPipelineInfo.GetPinnableReference(), ref pPropertiesCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DataGraphPipelinePropertyQueryResultArm);")]
        public static unsafe Result GetDataGraphPipelineProperties(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Count = 0)] uint propertiesCount, [Count(Parameter = "propertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelinePropertyQueryResultARM> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineProperties(device, pPipelineInfo, propertiesCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineProperties(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineInfoARM> pPipelineInfo, [Count(Count = 0)] uint propertiesCount, [Count(Parameter = "propertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelinePropertyQueryResultARM* pProperties)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineProperties(device, in pPipelineInfo.GetPinnableReference(), propertiesCount, pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DataGraphPipelinePropertyQueryResultArm);")]
        public static unsafe Result GetDataGraphPipelineProperties(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineInfoARM> pPipelineInfo, [Count(Count = 0)] uint propertiesCount, [Count(Parameter = "propertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelinePropertyQueryResultARM> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineProperties(device, in pPipelineInfo.GetPinnableReference(), propertiesCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBindPointRequirements = new(StructureType.DataGraphPipelineSessionBindPointRequirementArm);")]
        public static unsafe Result GetDataGraphPipelineSessionBindPointRequirements(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo, [Count(Count = 0)] uint* pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelineSessionBindPointRequirementARM> pBindPointRequirements)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineSessionBindPointRequirements(device, pInfo, pBindPointRequirementCount, out pBindPointRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineSessionBindPointRequirements(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo, [Count(Count = 0)] Span<uint> pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineSessionBindPointRequirements(device, pInfo, ref pBindPointRequirementCount.GetPinnableReference(), pBindPointRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBindPointRequirements = new(StructureType.DataGraphPipelineSessionBindPointRequirementArm);")]
        public static unsafe Result GetDataGraphPipelineSessionBindPointRequirements(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo, [Count(Count = 0)] Span<uint> pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelineSessionBindPointRequirementARM> pBindPointRequirements)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineSessionBindPointRequirements(device, pInfo, ref pBindPointRequirementCount.GetPinnableReference(), out pBindPointRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineSessionBindPointRequirements(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineSessionBindPointRequirementsInfoARM> pInfo, [Count(Count = 0)] uint* pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineSessionBindPointRequirements(device, in pInfo.GetPinnableReference(), pBindPointRequirementCount, pBindPointRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBindPointRequirements = new(StructureType.DataGraphPipelineSessionBindPointRequirementArm);")]
        public static unsafe Result GetDataGraphPipelineSessionBindPointRequirements(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineSessionBindPointRequirementsInfoARM> pInfo, [Count(Count = 0)] uint* pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelineSessionBindPointRequirementARM> pBindPointRequirements)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineSessionBindPointRequirements(device, in pInfo.GetPinnableReference(), pBindPointRequirementCount, out pBindPointRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDataGraphPipelineSessionBindPointRequirements(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineSessionBindPointRequirementsInfoARM> pInfo, [Count(Count = 0)] Span<uint> pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineSessionBindPointRequirements(device, in pInfo.GetPinnableReference(), ref pBindPointRequirementCount.GetPinnableReference(), pBindPointRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBindPointRequirements = new(StructureType.DataGraphPipelineSessionBindPointRequirementArm);")]
        public static unsafe Result GetDataGraphPipelineSessionBindPointRequirements(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineSessionBindPointRequirementsInfoARM> pInfo, [Count(Count = 0)] Span<uint> pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelineSessionBindPointRequirementARM> pBindPointRequirements)
        {
            // SpanOverloader
            return thisApi.GetDataGraphPipelineSessionBindPointRequirements(device, in pInfo.GetPinnableReference(), ref pBindPointRequirementCount.GetPinnableReference(), out pBindPointRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetDataGraphPipelineSessionMemoryRequirements(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionMemoryRequirementsInfoARM* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDataGraphPipelineSessionMemoryRequirements(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDataGraphPipelineSessionMemoryRequirements(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineSessionMemoryRequirementsInfoARM> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDataGraphPipelineSessionMemoryRequirements(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetDataGraphPipelineSessionMemoryRequirements(this ArmDataGraph thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineSessionMemoryRequirementsInfoARM> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDataGraphPipelineSessionMemoryRequirements(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyDataGraphProcessingEngineProperties = new(StructureType.QueueFamilyDataGraphProcessingEnginePropertiesArm);")]
        public static unsafe void GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties(this ArmDataGraph thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM* pQueueFamilyDataGraphProcessingEngineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueueFamilyDataGraphProcessingEnginePropertiesARM> pQueueFamilyDataGraphProcessingEngineProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties(physicalDevice, pQueueFamilyDataGraphProcessingEngineInfo, out pQueueFamilyDataGraphProcessingEngineProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties(this ArmDataGraph thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM> pQueueFamilyDataGraphProcessingEngineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyDataGraphProcessingEnginePropertiesARM* pQueueFamilyDataGraphProcessingEngineProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties(physicalDevice, in pQueueFamilyDataGraphProcessingEngineInfo.GetPinnableReference(), pQueueFamilyDataGraphProcessingEngineProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyDataGraphProcessingEngineProperties = new(StructureType.QueueFamilyDataGraphProcessingEnginePropertiesArm);")]
        public static unsafe void GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties(this ArmDataGraph thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM> pQueueFamilyDataGraphProcessingEngineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueueFamilyDataGraphProcessingEnginePropertiesARM> pQueueFamilyDataGraphProcessingEngineProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties(physicalDevice, in pQueueFamilyDataGraphProcessingEngineInfo.GetPinnableReference(), out pQueueFamilyDataGraphProcessingEngineProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyDataGraphProperties = new(StructureType.QueueFamilyDataGraphPropertiesArm);")]
        public static unsafe Result GetPhysicalDeviceQueueFamilyDataGraphProperties(this ArmDataGraph thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pQueueFamilyDataGraphPropertyCount, [Count(Parameter = "pQueueFamilyDataGraphPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueueFamilyDataGraphPropertiesARM> pQueueFamilyDataGraphProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceQueueFamilyDataGraphProperties(physicalDevice, queueFamilyIndex, pQueueFamilyDataGraphPropertyCount, out pQueueFamilyDataGraphProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceQueueFamilyDataGraphProperties(this ArmDataGraph thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pQueueFamilyDataGraphPropertyCount, [Count(Parameter = "pQueueFamilyDataGraphPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceQueueFamilyDataGraphProperties(physicalDevice, queueFamilyIndex, ref pQueueFamilyDataGraphPropertyCount.GetPinnableReference(), pQueueFamilyDataGraphProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyDataGraphProperties = new(StructureType.QueueFamilyDataGraphPropertiesArm);")]
        public static unsafe Result GetPhysicalDeviceQueueFamilyDataGraphProperties(this ArmDataGraph thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] Span<uint> pQueueFamilyDataGraphPropertyCount, [Count(Parameter = "pQueueFamilyDataGraphPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueueFamilyDataGraphPropertiesARM> pQueueFamilyDataGraphProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceQueueFamilyDataGraphProperties(physicalDevice, queueFamilyIndex, ref pQueueFamilyDataGraphPropertyCount.GetPinnableReference(), out pQueueFamilyDataGraphProperties.GetPinnableReference());
        }

    }
}

