// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_acceleration_structure")]
    public unsafe partial class KhrAccelerationStructure : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_acceleration_structure";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructuresKHR")]
        public unsafe partial Result BuildAccelerationStructures([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructuresKHR")]
        public unsafe partial Result BuildAccelerationStructures([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructuresKHR")]
        public unsafe partial Result BuildAccelerationStructures([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructuresKHR")]
        public unsafe partial Result BuildAccelerationStructures([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresKHR")]
        public unsafe partial void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresKHR")]
        public unsafe partial void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresKHR")]
        public unsafe partial void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresKHR")]
        public unsafe partial void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint* pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint* pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in ulong pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint* pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in ulong pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint* pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in ulong pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in ulong pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint* pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint* pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in ulong pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint* pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in ulong pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint* pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in ulong pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in ulong pIndirectDeviceAddresses, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint pIndirectStrides, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        public unsafe partial void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        public partial void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in CopyAccelerationStructureInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        public unsafe partial void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        public partial void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in CopyAccelerationStructureToMemoryInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        public unsafe partial void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        public partial void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in CopyMemoryToAccelerationStructureInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        public unsafe partial void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        public partial void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] in AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR")]
        public unsafe partial Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR")]
        public partial Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(FlowDirection.In)] in CopyAccelerationStructureInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        public unsafe partial Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        public partial Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(FlowDirection.In)] in CopyAccelerationStructureToMemoryInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        public unsafe partial Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        public partial Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(FlowDirection.In)] in CopyMemoryToAccelerationStructureInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR")]
        public unsafe partial void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR")]
        public partial void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureBuildSizesInfoKHR pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(FlowDirection.In)] in uint pMaxPrimitiveCounts, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(FlowDirection.In)] in uint pMaxPrimitiveCounts, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureBuildSizesInfoKHR pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureBuildSizesInfoKHR pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(FlowDirection.In)] in uint pMaxPrimitiveCounts, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        public partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureBuildGeometryInfoKHR pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(FlowDirection.In)] in uint pMaxPrimitiveCounts, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureBuildSizesInfoKHR pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        public unsafe partial ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureDeviceAddressInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        public partial ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureDeviceAddressInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        public unsafe partial void GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureVersionInfoKHR* pVersionInfo, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureCompatibilityKHR* pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        public unsafe partial void GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureVersionInfoKHR* pVersionInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureCompatibilityKHR pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        public unsafe partial void GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureVersionInfoKHR pVersionInfo, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureCompatibilityKHR* pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        public partial void GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureVersionInfoKHR pVersionInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureCompatibilityKHR pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        public unsafe partial Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] nuint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        public unsafe partial Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        public unsafe partial Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] in AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] nuint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        public partial Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] in AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged;

        public KhrAccelerationStructure(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

