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

namespace Silk.NET.Vulkan.Extensions.ARM
{
    [Extension("VK_ARM_data_graph")]
    public unsafe partial class ArmDataGraph : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_ARM_data_graph";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindDataGraphPipelineSessionMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BindDataGraphPipelineSessionMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BindDataGraphPipelineSessionMemoryInfoARM* pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindDataGraphPipelineSessionMemoryARM", Convention = CallingConvention.Winapi)]
        public partial Result BindDataGraphPipelineSessionMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BindDataGraphPipelineSessionMemoryInfoARM pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchDataGraphARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDispatchDataGraph([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DataGraphPipelineSessionARM session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineDispatchInfoARM* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchDataGraphARM", Convention = CallingConvention.Winapi)]
        public partial void CmdDispatchDataGraph([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DataGraphPipelineSessionARM session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineDispatchInfoARM pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelinesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineCreateInfoARM* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelinesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineCreateInfoARM* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelinesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineCreateInfoARM* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelinesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineCreateInfoARM* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelinesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineCreateInfoARM pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelinesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineCreateInfoARM pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelinesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineCreateInfoARM pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelinesARM", Convention = CallingConvention.Winapi)]
        public partial Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineCreateInfoARM pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelineSessionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelineSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionARM* pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelineSessionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelineSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelineSessionARM pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelineSessionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelineSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionARM* pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelineSessionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelineSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelineSessionARM pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelineSessionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelineSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionARM* pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelineSessionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelineSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelineSessionARM pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelineSessionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDataGraphPipelineSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionARM* pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDataGraphPipelineSessionARM", Convention = CallingConvention.Winapi)]
        public partial Result CreateDataGraphPipelineSession([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelineSessionARM pSession);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDataGraphPipelineSessionARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyDataGraphPipelineSession([Count(Count = 0)] Device device, [Count(Count = 0)] DataGraphPipelineSessionARM session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDataGraphPipelineSessionARM", Convention = CallingConvention.Winapi)]
        public partial void DestroyDataGraphPipelineSession([Count(Count = 0)] Device device, [Count(Count = 0)] DataGraphPipelineSessionARM session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineAvailableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Count = 0)] uint* pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelinePropertyARM* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineAvailableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Count = 0)] uint* pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelinePropertyARM pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineAvailableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Count = 0)] ref uint pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelinePropertyARM* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineAvailableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Count = 0)] ref uint pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelinePropertyARM pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineAvailableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineInfoARM pPipelineInfo, [Count(Count = 0)] uint* pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelinePropertyARM* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineAvailableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineInfoARM pPipelineInfo, [Count(Count = 0)] uint* pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelinePropertyARM pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineAvailableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineInfoARM pPipelineInfo, [Count(Count = 0)] ref uint pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelinePropertyARM* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineAvailablePropertiesARM", Convention = CallingConvention.Winapi)]
        public partial Result GetDataGraphPipelineAvailableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineInfoARM pPipelineInfo, [Count(Count = 0)] ref uint pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelinePropertyARM pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelinePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Count = 0)] uint propertiesCount, [Count(Parameter = "propertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelinePropertyQueryResultARM* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DataGraphPipelinePropertyQueryResultArm);")]
        [NativeApi(EntryPoint = "vkGetDataGraphPipelinePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Count = 0)] uint propertiesCount, [Count(Parameter = "propertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelinePropertyQueryResultARM pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelinePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineInfoARM pPipelineInfo, [Count(Count = 0)] uint propertiesCount, [Count(Parameter = "propertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelinePropertyQueryResultARM* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DataGraphPipelinePropertyQueryResultArm);")]
        [NativeApi(EntryPoint = "vkGetDataGraphPipelinePropertiesARM", Convention = CallingConvention.Winapi)]
        public partial Result GetDataGraphPipelineProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineInfoARM pPipelineInfo, [Count(Count = 0)] uint propertiesCount, [Count(Parameter = "propertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelinePropertyQueryResultARM pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineSessionBindPointRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo, [Count(Count = 0)] uint* pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBindPointRequirements = new(StructureType.DataGraphPipelineSessionBindPointRequirementArm);")]
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineSessionBindPointRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo, [Count(Count = 0)] uint* pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelineSessionBindPointRequirementARM pBindPointRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineSessionBindPointRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo, [Count(Count = 0)] ref uint pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBindPointRequirements = new(StructureType.DataGraphPipelineSessionBindPointRequirementArm);")]
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineSessionBindPointRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo, [Count(Count = 0)] ref uint pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelineSessionBindPointRequirementARM pBindPointRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineSessionBindPointRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionBindPointRequirementsInfoARM pInfo, [Count(Count = 0)] uint* pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBindPointRequirements = new(StructureType.DataGraphPipelineSessionBindPointRequirementArm);")]
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineSessionBindPointRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionBindPointRequirementsInfoARM pInfo, [Count(Count = 0)] uint* pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelineSessionBindPointRequirementARM pBindPointRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDataGraphPipelineSessionBindPointRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionBindPointRequirementsInfoARM pInfo, [Count(Count = 0)] ref uint pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBindPointRequirements = new(StructureType.DataGraphPipelineSessionBindPointRequirementArm);")]
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionBindPointRequirementsARM", Convention = CallingConvention.Winapi)]
        public partial Result GetDataGraphPipelineSessionBindPointRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionBindPointRequirementsInfoARM pInfo, [Count(Count = 0)] ref uint pBindPointRequirementCount, [Count(Parameter = "pBindPointRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DataGraphPipelineSessionBindPointRequirementARM pBindPointRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDataGraphPipelineSessionMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionMemoryRequirementsInfoARM* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDataGraphPipelineSessionMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionMemoryRequirementsInfoARM* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDataGraphPipelineSessionMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionMemoryRequirementsInfoARM pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetDataGraphPipelineSessionMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public partial void GetDataGraphPipelineSessionMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionMemoryRequirementsInfoARM pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM* pQueueFamilyDataGraphProcessingEngineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyDataGraphProcessingEnginePropertiesARM* pQueueFamilyDataGraphProcessingEngineProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyDataGraphProcessingEngineProperties = new(StructureType.QueueFamilyDataGraphProcessingEnginePropertiesArm);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM* pQueueFamilyDataGraphProcessingEngineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out QueueFamilyDataGraphProcessingEnginePropertiesARM pQueueFamilyDataGraphProcessingEngineProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM pQueueFamilyDataGraphProcessingEngineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyDataGraphProcessingEnginePropertiesARM* pQueueFamilyDataGraphProcessingEngineProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyDataGraphProcessingEngineProperties = new(StructureType.QueueFamilyDataGraphProcessingEnginePropertiesArm);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM", Convention = CallingConvention.Winapi)]
        public partial void GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM pQueueFamilyDataGraphProcessingEngineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out QueueFamilyDataGraphProcessingEnginePropertiesARM pQueueFamilyDataGraphProcessingEngineProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceQueueFamilyDataGraphProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pQueueFamilyDataGraphPropertyCount, [Count(Parameter = "pQueueFamilyDataGraphPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyDataGraphProperties = new(StructureType.QueueFamilyDataGraphPropertiesArm);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceQueueFamilyDataGraphProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint* pQueueFamilyDataGraphPropertyCount, [Count(Parameter = "pQueueFamilyDataGraphPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out QueueFamilyDataGraphPropertiesARM pQueueFamilyDataGraphProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceQueueFamilyDataGraphProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pQueueFamilyDataGraphPropertyCount, [Count(Parameter = "pQueueFamilyDataGraphPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyDataGraphProperties = new(StructureType.QueueFamilyDataGraphPropertiesArm);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceQueueFamilyDataGraphProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref uint pQueueFamilyDataGraphPropertyCount, [Count(Parameter = "pQueueFamilyDataGraphPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out QueueFamilyDataGraphPropertiesARM pQueueFamilyDataGraphProperties);

        /// <summary>To be documented.</summary>
        public unsafe Result BindDataGraphPipelineSessionMemory([Count(Count = 0)] Device device, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindDataGraphPipelineSessionMemoryInfoARM> pBindInfos)
        {
            // ImplicitCountSpanOverloader
            return BindDataGraphPipelineSessionMemory(device, (uint) pBindInfos.Length, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineCreateInfoARM* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateDataGraphPipelines(device, deferredOperation, pipelineCache, (uint) pPipelines.Length, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineCreateInfoARM* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateDataGraphPipelines(device, deferredOperation, pipelineCache, (uint) pPipelines.Length, pCreateInfos, in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineCreateInfoARM> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateDataGraphPipelines(device, deferredOperation, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineCreateInfoARM> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateDataGraphPipelines(device, deferredOperation, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineCreateInfoARM> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateDataGraphPipelines(device, deferredOperation, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateDataGraphPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DataGraphPipelineCreateInfoARM> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateDataGraphPipelines(device, deferredOperation, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DataGraphPipelinePropertyQueryResultArm);")]
        public unsafe Result GetDataGraphPipelineProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineInfoARM* pPipelineInfo, [Count(Parameter = "propertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelinePropertyQueryResultARM> pProperties)
        {
            // ImplicitCountSpanOverloader
            return GetDataGraphPipelineProperties(device, pPipelineInfo, (uint) pProperties.Length, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DataGraphPipelinePropertyQueryResultArm);")]
        public unsafe Result GetDataGraphPipelineProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineInfoARM pPipelineInfo, [Count(Parameter = "propertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DataGraphPipelinePropertyQueryResultARM> pProperties)
        {
            // ImplicitCountSpanOverloader
            return GetDataGraphPipelineProperties(device, in pPipelineInfo, (uint) pProperties.Length, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetDataGraphPipelineSessionMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DataGraphPipelineSessionMemoryRequirementsInfoARM* pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDataGraphPipelineSessionMemoryRequirements(device, pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetDataGraphPipelineSessionMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DataGraphPipelineSessionMemoryRequirementsInfoARM pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDataGraphPipelineSessionMemoryRequirements(device, in pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyDataGraphProcessingEngineProperties = new(StructureType.QueueFamilyDataGraphProcessingEnginePropertiesArm);")]
        public unsafe QueueFamilyDataGraphProcessingEnginePropertiesARM GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM* pQueueFamilyDataGraphProcessingEngineInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties(physicalDevice, pQueueFamilyDataGraphProcessingEngineInfo, out QueueFamilyDataGraphProcessingEnginePropertiesARM silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyDataGraphProcessingEngineProperties = new(StructureType.QueueFamilyDataGraphProcessingEnginePropertiesArm);")]
        public unsafe QueueFamilyDataGraphProcessingEnginePropertiesARM GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM pQueueFamilyDataGraphProcessingEngineInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPhysicalDeviceQueueFamilyDataGraphProcessingEngineProperties(physicalDevice, in pQueueFamilyDataGraphProcessingEngineInfo, out QueueFamilyDataGraphProcessingEnginePropertiesARM silkRet);
            return silkRet;
        }

        public ArmDataGraph(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

