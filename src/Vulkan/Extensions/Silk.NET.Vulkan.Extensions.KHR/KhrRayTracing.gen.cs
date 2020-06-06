// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_ray_tracing")]
    public unsafe partial class KhrRayTracing : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_ray_tracing";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindAccelerationStructureMemoryKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindAccelerationStructureMemoryInfoKHR* pBindInfos)
            => ImplBindAccelerationStructureMemory(device, bindInfoCount, pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindAccelerationStructureMemoryKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindAccelerationStructureMemoryInfoKHR pBindInfos)
            => ImplBindAccelerationStructureMemory(device, bindInfoCount, pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result BuildAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildOffsetInfoKHR** ppOffsetInfos)
            => ImplBuildAccelerationStructure(device, infoCount, pInfos, ppOffsetInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result BuildAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildOffsetInfoKHR* ppOffsetInfos)
            => ImplBuildAccelerationStructure(device, infoCount, pInfos, ppOffsetInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBuildAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildOffsetInfoKHR** ppOffsetInfos)
            => ImplCmdBuildAccelerationStructure(commandBuffer, infoCount, pInfos, ppOffsetInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBuildAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildOffsetInfoKHR* ppOffsetInfos)
            => ImplCmdBuildAccelerationStructure(commandBuffer, infoCount, pInfos, ppOffsetInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureIndirectKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBuildAccelerationStructureIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfo, [Count(Count = 0)] Buffer indirectBuffer, [Count(Count = 0)] ulong indirectOffset, [Count(Count = 0)] uint indirectStride)
            => ImplCmdBuildAccelerationStructureIndirect(commandBuffer, pInfo, indirectBuffer, indirectOffset, indirectStride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureIndirectKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBuildAccelerationStructureIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureBuildGeometryInfoKHR pInfo, [Count(Count = 0)] Buffer indirectBuffer, [Count(Count = 0)] ulong indirectOffset, [Count(Count = 0)] uint indirectStride)
            => ImplCmdBuildAccelerationStructureIndirect(commandBuffer, pInfo, indirectBuffer, indirectOffset, indirectStride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo)
            => ImplCmdCopyAccelerationStructure(commandBuffer, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureInfoKHR pInfo)
            => ImplCmdCopyAccelerationStructure(commandBuffer, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo)
            => ImplCmdCopyAccelerationStructureToMemory(commandBuffer, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureToMemoryInfoKHR pInfo)
            => ImplCmdCopyAccelerationStructureToMemory(commandBuffer, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo)
            => ImplCmdCopyMemoryToAccelerationStructure(commandBuffer, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyMemoryToAccelerationStructureInfoKHR pInfo)
            => ImplCmdCopyMemoryToAccelerationStructure(commandBuffer, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
            => ImplCmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
            => ImplCmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
            => ImplCmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, buffer, offset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
            => ImplCmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, buffer, offset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery)
            => ImplCmdWriteAccelerationStructuresProperties(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ref AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery)
            => ImplCmdWriteAccelerationStructuresProperties(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo)
            => ImplCopyAccelerationStructure(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureInfoKHR pInfo)
            => ImplCopyAccelerationStructure(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo)
            => ImplCopyAccelerationStructureToMemory(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureToMemoryInfoKHR pInfo)
            => ImplCopyAccelerationStructureToMemory(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo)
            => ImplCopyMemoryToAccelerationStructure(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyMemoryToAccelerationStructureInfoKHR pInfo)
            => ImplCopyMemoryToAccelerationStructure(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure)
            => ImplCreateAccelerationStructure(device, pCreateInfo, pAllocator, pAccelerationStructure);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure)
            => ImplCreateAccelerationStructure(device, pCreateInfo, pAllocator, pAccelerationStructure);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
            => ImplCreateRayTracingPipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ref RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines)
            => ImplCreateRayTracingPipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyAccelerationStructure(device, accelerationStructure, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyAccelerationStructure(device, accelerationStructure, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureDeviceAddressInfoKHR* pInfo)
            => ImplGetAccelerationStructureDeviceAddress(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureDeviceAddressInfoKHR pInfo)
            => ImplGetAccelerationStructureDeviceAddress(device, pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureMemoryRequirementsInfoKHR* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
            => ImplGetAccelerationStructureMemoryRequirements(device, pInfo, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureMemoryRequirementsInfoKHR pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements)
            => ImplGetAccelerationStructureMemoryRequirements(device, pInfo, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureVersionKHR* version)
            => ImplGetDeviceAccelerationStructureCompatibility(device, version);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureVersionKHR version)
            => ImplGetDeviceAccelerationStructureCompatibility(device, version);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetRayTracingCaptureReplayShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData)
            => ImplGetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, dataSize, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetRayTracingCaptureReplayShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged
            => ImplGetRayTracingCaptureReplayShaderGroupHandles<T0>(device, pipeline, firstGroup, groupCount, dataSize, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetRayTracingShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData)
            => ImplGetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, dataSize, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged
            => ImplGetRayTracingShaderGroupHandles<T0>(device, pipeline, firstGroup, groupCount, dataSize, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] UIntPtr stride)
            => ImplWriteAccelerationStructuresProperties(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ref AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] UIntPtr stride) where T0 : unmanaged
            => ImplWriteAccelerationStructuresProperties<T0>(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetRayTracingCaptureReplayShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData)
        {
            // IntPtrOverloader
            return GetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), pData);
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetRayTracingCaptureReplayShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), ref pData);
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetRayTracingShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData)
        {
            // IntPtrOverloader
            return GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), pData);
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), ref pData);
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] uint stride)
        {
            // IntPtrOverloader
            return WriteAccelerationStructuresProperties(device, accelerationStructureCount, pAccelerationStructures, queryType, new UIntPtr(dataSize), pData, new UIntPtr(stride));
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ref AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            return WriteAccelerationStructuresProperties(device, accelerationStructureCount, ref pAccelerationStructures, queryType, new UIntPtr(dataSize), ref pData, new UIntPtr(stride));
        }

        public KhrRayTracing(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

