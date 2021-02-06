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
    public static class KhrRayTracingPipelineOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, deferredOperation, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, deferredOperation, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, deferredOperation, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), pPipelines);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRayTracingPipelines(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // SpanOverloader
            return thisApi.CreateRayTracingPipelines(device, deferredOperation, pipelineCache, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRayTracingCaptureReplayShaderGroupHandles<T0>(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, dataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRayTracingShaderGroupHandles<T0>(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, dataSize, ref pData.GetPinnableReference());
        }

    }
}

