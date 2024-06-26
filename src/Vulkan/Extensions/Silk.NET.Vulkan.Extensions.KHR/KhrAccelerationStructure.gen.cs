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
        [NativeApi(EntryPoint = "vkBuildAccelerationStructuresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BuildAccelerationStructures([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructuresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BuildAccelerationStructures([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructuresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BuildAccelerationStructures([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyAccelerationStructureInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyAccelerationStructureToMemoryInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyMemoryToAccelerationStructureInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public partial Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyAccelerationStructureInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR", Convention = CallingConvention.Winapi)]
        public partial Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyAccelerationStructureToMemoryInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public partial Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyMemoryToAccelerationStructureInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR", Convention = CallingConvention.Winapi)]
        public partial void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureBuildSizesInfoKHR pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureBuildSizesInfoKHR pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureBuildSizesInfoKHR pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        [NativeApi(EntryPoint = "vkGetAccelerationStructureBuildSizesKHR", Convention = CallingConvention.Winapi)]
        public partial void GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureBuildSizesInfoKHR pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureDeviceAddressInfoKHR* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR", Convention = CallingConvention.Winapi)]
        public partial ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureDeviceAddressInfoKHR pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureVersionInfoKHR* pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureCompatibilityKHR* pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureVersionInfoKHR* pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureCompatibilityKHR pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureVersionInfoKHR pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureCompatibilityKHR* pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR", Convention = CallingConvention.Winapi)]
        public partial void GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureVersionInfoKHR pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureCompatibilityKHR pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] nuint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] nuint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        public unsafe Result BuildAccelerationStructures([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            // ImplicitCountSpanOverloader
            return BuildAccelerationStructures(device, deferredOperation, (uint) pInfos.Length, in pInfos.GetPinnableReference(), ppBuildRangeInfos);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result BuildAccelerationStructures([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            // ImplicitCountSpanOverloader
            return BuildAccelerationStructures(device, deferredOperation, (uint) pInfos.Length, in pInfos.GetPinnableReference(), in ppBuildRangeInfos);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructures(commandBuffer, (uint) pInfos.Length, in pInfos.GetPinnableReference(), ppBuildRangeInfos);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructures([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructures(commandBuffer, (uint) pInfos.Length, in pInfos.GetPinnableReference(), in ppBuildRangeInfos);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectStrides.Length, pInfos, pIndirectDeviceAddresses, in pIndirectStrides.GetPinnableReference(), ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectStrides.Length, pInfos, pIndirectDeviceAddresses, in pIndirectStrides.GetPinnableReference(), in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectDeviceAddresses.Length, pInfos, in pIndirectDeviceAddresses.GetPinnableReference(), pIndirectStrides, ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectDeviceAddresses.Length, pInfos, in pIndirectDeviceAddresses.GetPinnableReference(), pIndirectStrides, in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectStrides.Length, pInfos, in pIndirectDeviceAddresses.GetPinnableReference(), in pIndirectStrides.GetPinnableReference(), ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectStrides.Length, pInfos, in pIndirectDeviceAddresses.GetPinnableReference(), in pIndirectStrides.GetPinnableReference(), in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pInfos.Length, in pInfos.GetPinnableReference(), pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pInfos.Length, in pInfos.GetPinnableReference(), pIndirectDeviceAddresses, pIndirectStrides, in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectStrides.Length, in pInfos.GetPinnableReference(), pIndirectDeviceAddresses, in pIndirectStrides.GetPinnableReference(), ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectStrides.Length, in pInfos.GetPinnableReference(), pIndirectDeviceAddresses, in pIndirectStrides.GetPinnableReference(), in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectDeviceAddresses.Length, in pInfos.GetPinnableReference(), in pIndirectDeviceAddresses.GetPinnableReference(), pIndirectStrides, ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectDeviceAddresses.Length, in pInfos.GetPinnableReference(), in pIndirectDeviceAddresses.GetPinnableReference(), pIndirectStrides, in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectStrides.Length, in pInfos.GetPinnableReference(), in pIndirectDeviceAddresses.GetPinnableReference(), in pIndirectStrides.GetPinnableReference(), ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildAccelerationStructuresIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // ImplicitCountSpanOverloader
            CmdBuildAccelerationStructuresIndirect(commandBuffer, (uint) pIndirectStrides.Length, in pInfos.GetPinnableReference(), in pIndirectDeviceAddresses.GetPinnableReference(), in pIndirectStrides.GetPinnableReference(), in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureKHR> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery)
        {
            // ImplicitCountSpanOverloader
            CmdWriteAccelerationStructuresProperties(commandBuffer, (uint) pAccelerationStructures.Length, in pAccelerationStructures.GetPinnableReference(), queryType, queryPool, firstQuery);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Parameter = "dataSize")] Span<T0> pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return WriteAccelerationStructuresProperties(device, accelerationStructureCount, pAccelerationStructures, queryType, (nuint) ((pData.Length) * Unsafe.SizeOf<T0>()), ref pData.GetPinnableReference(), stride);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureKHR> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] nuint stride)
        {
            // ImplicitCountSpanOverloader
            return WriteAccelerationStructuresProperties(device, (uint) pAccelerationStructures.Length, in pAccelerationStructures.GetPinnableReference(), queryType, dataSize, pData, stride);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureKHR> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Parameter = "dataSize")] Span<T0> pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return WriteAccelerationStructuresProperties(device, (uint) pAccelerationStructures.Length, in pAccelerationStructures.GetPinnableReference(), queryType, (nuint) ((pData.Length) * Unsafe.SizeOf<T0>()), ref pData.GetPinnableReference(), stride);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public unsafe AccelerationStructureBuildSizesInfoKHR GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pMaxPrimitiveCounts)
        {
            // NonKhrReturnTypeOverloader
            GetAccelerationStructureBuildSizes(device, buildType, pBuildInfo, pMaxPrimitiveCounts, out AccelerationStructureBuildSizesInfoKHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public unsafe AccelerationStructureBuildSizesInfoKHR GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pMaxPrimitiveCounts)
        {
            // NonKhrReturnTypeOverloader
            GetAccelerationStructureBuildSizes(device, buildType, pBuildInfo, in pMaxPrimitiveCounts, out AccelerationStructureBuildSizesInfoKHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public unsafe AccelerationStructureBuildSizesInfoKHR GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pMaxPrimitiveCounts)
        {
            // NonKhrReturnTypeOverloader
            GetAccelerationStructureBuildSizes(device, buildType, in pBuildInfo, pMaxPrimitiveCounts, out AccelerationStructureBuildSizesInfoKHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public unsafe AccelerationStructureBuildSizesInfoKHR GetAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildGeometryInfoKHR pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pMaxPrimitiveCounts)
        {
            // NonKhrReturnTypeOverloader
            GetAccelerationStructureBuildSizes(device, buildType, in pBuildInfo, in pMaxPrimitiveCounts, out AccelerationStructureBuildSizesInfoKHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public unsafe AccelerationStructureCompatibilityKHR GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureVersionInfoKHR* pVersionInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceAccelerationStructureCompatibility(device, pVersionInfo, out AccelerationStructureCompatibilityKHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public unsafe AccelerationStructureCompatibilityKHR GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureVersionInfoKHR pVersionInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceAccelerationStructureCompatibility(device, in pVersionInfo, out AccelerationStructureCompatibilityKHR silkRet);
            return silkRet;
        }

        public KhrAccelerationStructure(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

