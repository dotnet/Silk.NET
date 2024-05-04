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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrAccelerationStructureOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result BuildAccelerationStructures(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            // SpanOverloader
            return thisApi.BuildAccelerationStructures(device, deferredOperation, infoCount, in pInfos.GetPinnableReference(), ppBuildRangeInfos);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result BuildAccelerationStructures(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            // SpanOverloader
            return thisApi.BuildAccelerationStructures(device, deferredOperation, infoCount, in pInfos.GetPinnableReference(), in ppBuildRangeInfos);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructures(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructures(commandBuffer, infoCount, in pInfos.GetPinnableReference(), ppBuildRangeInfos);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructures(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructures(commandBuffer, infoCount, in pInfos.GetPinnableReference(), in ppBuildRangeInfos);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, in pIndirectStrides.GetPinnableReference(), ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, in pIndirectStrides.GetPinnableReference(), in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, pInfos, in pIndirectDeviceAddresses.GetPinnableReference(), pIndirectStrides, ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, pInfos, in pIndirectDeviceAddresses.GetPinnableReference(), pIndirectStrides, in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, pInfos, in pIndirectDeviceAddresses.GetPinnableReference(), in pIndirectStrides.GetPinnableReference(), ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, pInfos, in pIndirectDeviceAddresses.GetPinnableReference(), in pIndirectStrides.GetPinnableReference(), in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, in pInfos.GetPinnableReference(), pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, in pInfos.GetPinnableReference(), pIndirectDeviceAddresses, pIndirectStrides, in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, in pInfos.GetPinnableReference(), pIndirectDeviceAddresses, in pIndirectStrides.GetPinnableReference(), ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, in pInfos.GetPinnableReference(), pIndirectDeviceAddresses, in pIndirectStrides.GetPinnableReference(), in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, in pInfos.GetPinnableReference(), in pIndirectDeviceAddresses.GetPinnableReference(), pIndirectStrides, ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, in pInfos.GetPinnableReference(), in pIndirectDeviceAddresses.GetPinnableReference(), pIndirectStrides, in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, in pInfos.GetPinnableReference(), in pIndirectDeviceAddresses.GetPinnableReference(), in pIndirectStrides.GetPinnableReference(), ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructuresIndirect(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pIndirectDeviceAddresses, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pIndirectStrides, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* ppMaxPrimitiveCounts)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructuresIndirect(commandBuffer, infoCount, in pInfos.GetPinnableReference(), in pIndirectDeviceAddresses.GetPinnableReference(), in pIndirectStrides.GetPinnableReference(), in ppMaxPrimitiveCounts);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyAccelerationStructureInfoKHR> pInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyAccelerationStructure(commandBuffer, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyAccelerationStructureToMemory(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyAccelerationStructureToMemoryInfoKHR> pInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyAccelerationStructureToMemory(commandBuffer, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyMemoryToAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyMemoryToAccelerationStructureInfoKHR> pInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyMemoryToAccelerationStructure(commandBuffer, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWriteAccelerationStructuresProperties(this KhrAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureKHR> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery)
        {
            // SpanOverloader
            thisApi.CmdWriteAccelerationStructuresProperties(commandBuffer, accelerationStructureCount, in pAccelerationStructures.GetPinnableReference(), queryType, queryPool, firstQuery);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyAccelerationStructureInfoKHR> pInfo)
        {
            // SpanOverloader
            return thisApi.CopyAccelerationStructure(device, deferredOperation, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyAccelerationStructureToMemory(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyAccelerationStructureToMemoryInfoKHR> pInfo)
        {
            // SpanOverloader
            return thisApi.CopyAccelerationStructureToMemory(device, deferredOperation, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyMemoryToAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyMemoryToAccelerationStructureInfoKHR> pInfo)
        {
            // SpanOverloader
            return thisApi.CopyMemoryToAccelerationStructure(device, deferredOperation, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureKHR> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, pCreateInfo, pAllocator, out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, pCreateInfo, in pAllocator.GetPinnableReference(), pAccelerationStructure);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureKHR> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), pAllocator, pAccelerationStructure);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureKHR> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pAccelerationStructure);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureKHR> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyAccelerationStructure(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyAccelerationStructure(device, accelerationStructure, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public static unsafe void GetAccelerationStructureBuildSizes(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureBuildSizesInfoKHR> pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureBuildSizes(device, buildType, pBuildInfo, pMaxPrimitiveCounts, out pSizeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetAccelerationStructureBuildSizes(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureBuildSizes(device, buildType, pBuildInfo, in pMaxPrimitiveCounts.GetPinnableReference(), pSizeInfo);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public static unsafe void GetAccelerationStructureBuildSizes(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureBuildSizesInfoKHR> pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureBuildSizes(device, buildType, pBuildInfo, in pMaxPrimitiveCounts.GetPinnableReference(), out pSizeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetAccelerationStructureBuildSizes(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureBuildSizes(device, buildType, in pBuildInfo.GetPinnableReference(), pMaxPrimitiveCounts, pSizeInfo);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public static unsafe void GetAccelerationStructureBuildSizes(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureBuildSizesInfoKHR> pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureBuildSizes(device, buildType, in pBuildInfo.GetPinnableReference(), pMaxPrimitiveCounts, out pSizeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetAccelerationStructureBuildSizes(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureBuildSizes(device, buildType, in pBuildInfo.GetPinnableReference(), in pMaxPrimitiveCounts.GetPinnableReference(), pSizeInfo);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public static unsafe void GetAccelerationStructureBuildSizes(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pBuildInfo, [Count(Computed = "pBuildInfo->geometryCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pMaxPrimitiveCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureBuildSizesInfoKHR> pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureBuildSizes(device, buildType, in pBuildInfo.GetPinnableReference(), in pMaxPrimitiveCounts.GetPinnableReference(), out pSizeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe ulong GetAccelerationStructureDeviceAddress(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureDeviceAddressInfoKHR> pInfo)
        {
            // SpanOverloader
            return thisApi.GetAccelerationStructureDeviceAddress(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceAccelerationStructureCompatibility(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureVersionInfoKHR* pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureCompatibilityKHR> pCompatibility)
        {
            // SpanOverloader
            thisApi.GetDeviceAccelerationStructureCompatibility(device, pVersionInfo, out pCompatibility.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceAccelerationStructureCompatibility(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureVersionInfoKHR> pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureCompatibilityKHR* pCompatibility)
        {
            // SpanOverloader
            thisApi.GetDeviceAccelerationStructureCompatibility(device, in pVersionInfo.GetPinnableReference(), pCompatibility);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceAccelerationStructureCompatibility(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureVersionInfoKHR> pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureCompatibilityKHR> pCompatibility)
        {
            // SpanOverloader
            thisApi.GetDeviceAccelerationStructureCompatibility(device, in pVersionInfo.GetPinnableReference(), out pCompatibility.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WriteAccelerationStructuresProperties<T0>(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteAccelerationStructuresProperties(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, ref pData.GetPinnableReference(), stride);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WriteAccelerationStructuresProperties(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureKHR> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] nuint stride)
        {
            // SpanOverloader
            return thisApi.WriteAccelerationStructuresProperties(device, accelerationStructureCount, in pAccelerationStructures.GetPinnableReference(), queryType, dataSize, pData, stride);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WriteAccelerationStructuresProperties<T0>(this KhrAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureKHR> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteAccelerationStructuresProperties(device, accelerationStructureCount, in pAccelerationStructures.GetPinnableReference(), queryType, dataSize, ref pData.GetPinnableReference(), stride);
        }

    }
}

