// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_ray_tracing")]
    public abstract unsafe partial class NVRayTracing : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkBindAccelerationStructureMemoryNV")]
        public abstract unsafe Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindAccelerationStructureMemoryInfoKHR* pBindInfos);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkBindAccelerationStructureMemoryNV")]
        public abstract Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindAccelerationStructureMemoryInfoKHR pBindInfos);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureNV")]
        public abstract unsafe void CmdBuildAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureInfoNV* pInfo, [Count(Count = 0)] Buffer instanceData, [Count(Count = 0)] ulong instanceOffset, [Count(Count = 0)] Bool32 update, [Count(Count = 0)] AccelerationStructureKHR dst, [Count(Count = 0)] AccelerationStructureKHR src, [Count(Count = 0)] Buffer scratch, [Count(Count = 0)] ulong scratchOffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureNV")]
        public abstract void CmdBuildAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureInfoNV pInfo, [Count(Count = 0)] Buffer instanceData, [Count(Count = 0)] ulong instanceOffset, [Count(Count = 0)] Bool32 update, [Count(Count = 0)] AccelerationStructureKHR dst, [Count(Count = 0)] AccelerationStructureKHR src, [Count(Count = 0)] Buffer scratch, [Count(Count = 0)] ulong scratchOffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureNV")]
        public abstract void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] AccelerationStructureKHR dst, [Count(Count = 0)] AccelerationStructureKHR src, [Count(Count = 0)] CopyAccelerationStructureModeKHR mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdTraceRaysNV")]
        public abstract void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer raygenShaderBindingTableBuffer, [Count(Count = 0)] ulong raygenShaderBindingOffset, [Count(Count = 0)] Buffer missShaderBindingTableBuffer, [Count(Count = 0)] ulong missShaderBindingOffset, [Count(Count = 0)] ulong missShaderBindingStride, [Count(Count = 0)] Buffer hitShaderBindingTableBuffer, [Count(Count = 0)] ulong hitShaderBindingOffset, [Count(Count = 0)] ulong hitShaderBindingStride, [Count(Count = 0)] Buffer callableShaderBindingTableBuffer, [Count(Count = 0)] ulong callableShaderBindingOffset, [Count(Count = 0)] ulong callableShaderBindingStride, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
        public abstract unsafe void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
        public abstract void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ref AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCompileDeferredNV")]
        public abstract Result CompileDeferred([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint shader);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureNV")]
        public abstract unsafe Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureNV* pAccelerationStructure);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureNV")]
        public abstract Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureNV pAccelerationStructure);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public abstract unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoNV* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public abstract Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ref RayTracingPipelineCreateInfoNV pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureNV")]
        public abstract unsafe void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureNV")]
        public abstract void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetAccelerationStructureHandleNV")]
        public abstract unsafe Result GetAccelerationStructureHandle([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetAccelerationStructureHandleNV")]
        public abstract Result GetAccelerationStructureHandle<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
        public abstract unsafe void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureMemoryRequirementsInfoNV* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2KHR* pMemoryRequirements);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
        public abstract void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureMemoryRequirementsInfoNV pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2KHR pMemoryRequirements);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesNV")]
        public abstract unsafe Result GetRayTracingShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesNV")]
        public abstract Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        public unsafe Result GetAccelerationStructureHandle([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData)
        {
            // IntPtrOverloader
            return GetAccelerationStructureHandle(device, accelerationStructure, new UIntPtr(dataSize), pData);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetAccelerationStructureHandle<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetAccelerationStructureHandle(device, accelerationStructure, new UIntPtr(dataSize), ref pData);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetRayTracingShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData)
        {
            // IntPtrOverloader
            return GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), pData);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), ref pData);
        }

        public NVRayTracing(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

