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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_acceleration_structure")]
    public unsafe partial class KhrAccelerationStructure : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_acceleration_structure";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructuresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BuildAccelerationStructures([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureDeviceAddressInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureVersionInfoKHR* pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureCompatibilityKHR* pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] nuint stride);

        public KhrAccelerationStructure(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

