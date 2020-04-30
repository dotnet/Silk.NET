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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_ray_tracing")]
    public abstract unsafe partial class KhrRayTracing : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkBindAccelerationStructureMemoryKHR")]
        public abstract unsafe Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindAccelerationStructureMemoryInfoKHR* pBindInfos);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkBindAccelerationStructureMemoryKHR")]
        public abstract Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindAccelerationStructureMemoryInfoKHR pBindInfos);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkBuildAccelerationStructureKHR")]
        public abstract unsafe Result BuildAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildOffsetInfoKHR** ppOffsetInfos);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkBuildAccelerationStructureKHR")]
        public abstract unsafe Result BuildAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildOffsetInfoKHR* ppOffsetInfos);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureKHR")]
        public abstract unsafe void CmdBuildAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildOffsetInfoKHR** ppOffsetInfos);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureKHR")]
        public abstract unsafe void CmdBuildAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildOffsetInfoKHR* ppOffsetInfos);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureIndirectKHR")]
        public abstract unsafe void CmdBuildAccelerationStructureIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfo, [Count(Count = 0)] Buffer indirectBuffer, [Count(Count = 0)] ulong indirectOffset, [Count(Count = 0)] uint indirectStride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureIndirectKHR")]
        public abstract void CmdBuildAccelerationStructureIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureBuildGeometryInfoKHR pInfo, [Count(Count = 0)] Buffer indirectBuffer, [Count(Count = 0)] ulong indirectOffset, [Count(Count = 0)] uint indirectStride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        public abstract unsafe void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        public abstract void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureInfoKHR pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        public abstract unsafe void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        public abstract void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureToMemoryInfoKHR pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        public abstract unsafe void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        public abstract void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyMemoryToAccelerationStructureInfoKHR pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public abstract unsafe void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public abstract void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public abstract unsafe void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public abstract void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        public abstract unsafe void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        public abstract void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ref AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR")]
        public abstract unsafe Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR")]
        public abstract Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureInfoKHR pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        public abstract unsafe Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        public abstract Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureToMemoryInfoKHR pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        public abstract unsafe Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        public abstract Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyMemoryToAccelerationStructureInfoKHR pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public abstract unsafe Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public abstract Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public abstract unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public abstract Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ref RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR")]
        public abstract unsafe void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR")]
        public abstract void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        public abstract unsafe ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureDeviceAddressInfoKHR* pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        public abstract ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureDeviceAddressInfoKHR pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsKHR")]
        public abstract unsafe void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureMemoryRequirementsInfoKHR* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsKHR")]
        public abstract void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureMemoryRequirementsInfoKHR pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        public abstract unsafe Result GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureVersionKHR* version);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        public abstract Result GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureVersionKHR version);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        public abstract unsafe Result GetRayTracingCaptureReplayShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        public abstract Result GetRayTracingCaptureReplayShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        public abstract unsafe Result GetRayTracingShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        public abstract Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        public abstract unsafe Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] UIntPtr stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        public abstract Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ref AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] UIntPtr stride) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        public unsafe Result GetRayTracingCaptureReplayShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData)
        {
            // IntPtrOverloader
            return GetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), pData);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetRayTracingCaptureReplayShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), ref pData);
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

        /// <summary>To be added.</summary>
        public unsafe Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] uint stride)
        {
            // IntPtrOverloader
            return WriteAccelerationStructuresProperties(device, accelerationStructureCount, pAccelerationStructures, queryType, new UIntPtr(dataSize), pData, new UIntPtr(stride));
        }

        /// <summary>To be added.</summary>
        public unsafe Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ref AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            return WriteAccelerationStructuresProperties(device, accelerationStructureCount, ref pAccelerationStructures, queryType, new UIntPtr(dataSize), ref pData, new UIntPtr(stride));
        }

        public KhrRayTracing(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

