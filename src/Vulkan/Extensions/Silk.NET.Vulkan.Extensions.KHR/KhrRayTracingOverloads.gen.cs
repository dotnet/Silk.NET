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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrRayTracingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result BindAccelerationStructureMemory(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<BindAccelerationStructureMemoryInfoKHR> pBindInfos)
        {
            // SpanOverloader
            return thisApi.BindAccelerationStructureMemory(device, bindInfoCount, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result BuildAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildOffsetInfoKHR** ppOffsetInfos)
        {
            // SpanOverloader
            return thisApi.BuildAccelerationStructure(device, infoCount, in pInfos.GetPinnableReference(), ppOffsetInfos);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result BuildAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildOffsetInfoKHR* ppOffsetInfos)
        {
            // SpanOverloader
            return thisApi.BuildAccelerationStructure(device, infoCount, in pInfos.GetPinnableReference(), in ppOffsetInfos);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildOffsetInfoKHR** ppOffsetInfos)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructure(commandBuffer, infoCount, in pInfos.GetPinnableReference(), ppOffsetInfos);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] in AccelerationStructureBuildOffsetInfoKHR* ppOffsetInfos)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructure(commandBuffer, infoCount, in pInfos.GetPinnableReference(), in ppOffsetInfos);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildAccelerationStructureIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureBuildGeometryInfoKHR> pInfo, [Count(Count = 0)] Buffer indirectBuffer, [Count(Count = 0)] ulong indirectOffset, [Count(Count = 0)] uint indirectStride)
        {
            // SpanOverloader
            thisApi.CmdBuildAccelerationStructureIndirect(commandBuffer, in pInfo.GetPinnableReference(), indirectBuffer, indirectOffset, indirectStride);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<CopyAccelerationStructureInfoKHR> pInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyAccelerationStructure(commandBuffer, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyAccelerationStructureToMemory(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<CopyAccelerationStructureToMemoryInfoKHR> pInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyAccelerationStructureToMemory(commandBuffer, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyMemoryToAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<CopyMemoryToAccelerationStructureInfoKHR> pInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyMemoryToAccelerationStructure(commandBuffer, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedBufferRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), buffer, offset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWriteAccelerationStructuresProperties(this KhrRayTracing thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureKHR> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery)
        {
            // SpanOverloader
            thisApi.CmdWriteAccelerationStructuresProperties(commandBuffer, accelerationStructureCount, in pAccelerationStructures.GetPinnableReference(), queryType, queryPool, firstQuery);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<CopyAccelerationStructureInfoKHR> pInfo)
        {
            // SpanOverloader
            return thisApi.CopyAccelerationStructure(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyAccelerationStructureToMemory(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<CopyAccelerationStructureToMemoryInfoKHR> pInfo)
        {
            // SpanOverloader
            return thisApi.CopyAccelerationStructureToMemory(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyMemoryToAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<CopyMemoryToAccelerationStructureInfoKHR> pInfo)
        {
            // SpanOverloader
            return thisApi.CopyMemoryToAccelerationStructure(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<AccelerationStructureKHR> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, pCreateInfo, pAllocator, out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, pCreateInfo, in pAllocator.GetPinnableReference(), pAccelerationStructure);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<AccelerationStructureKHR> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), pAllocator, pAccelerationStructure);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<AccelerationStructureKHR> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pAccelerationStructure);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<AccelerationStructureKHR> pAccelerationStructure)
        {
            // SpanOverloader
            return thisApi.CreateAccelerationStructure(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pAccelerationStructure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyAccelerationStructure(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyAccelerationStructure(device, accelerationStructure, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe ulong GetAccelerationStructureDeviceAddress(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureDeviceAddressInfoKHR> pInfo)
        {
            // SpanOverloader
            return thisApi.GetAccelerationStructureDeviceAddress(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetAccelerationStructureMemoryRequirements(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureMemoryRequirementsInfoKHR* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureMemoryRequirements(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetAccelerationStructureMemoryRequirements(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureMemoryRequirementsInfoKHR> pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureMemoryRequirements(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetAccelerationStructureMemoryRequirements(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureMemoryRequirementsInfoKHR> pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetAccelerationStructureMemoryRequirements(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceAccelerationStructureCompatibility(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureVersionKHR> version)
        {
            // SpanOverloader
            return thisApi.GetDeviceAccelerationStructureCompatibility(device, in version.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRayTracingCaptureReplayShaderGroupHandles<T0>(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, dataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRayTracingShaderGroupHandles<T0>(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, dataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WriteAccelerationStructuresProperties<T0>(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] Span<T0> pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteAccelerationStructuresProperties(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, ref pData.GetPinnableReference(), stride);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WriteAccelerationStructuresProperties(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureKHR> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] nuint stride)
        {
            // SpanOverloader
            return thisApi.WriteAccelerationStructuresProperties(device, accelerationStructureCount, in pAccelerationStructures.GetPinnableReference(), queryType, dataSize, pData, stride);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WriteAccelerationStructuresProperties<T0>(this KhrRayTracing thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureKHR> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] Span<T0> pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteAccelerationStructuresProperties(device, accelerationStructureCount, in pAccelerationStructures.GetPinnableReference(), queryType, dataSize, ref pData.GetPinnableReference(), stride);
        }

    }
}

