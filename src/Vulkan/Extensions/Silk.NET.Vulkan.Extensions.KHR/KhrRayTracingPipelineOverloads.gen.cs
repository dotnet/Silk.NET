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
    public static class KhrRayTracingPipelineOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRays(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth)
        {
            // SpanOverloader
            thisApi.CmdTraceRays(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), width, height, depth);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, pRaygenShaderBindingTable, in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), pMissShaderBindingTable, in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), pHitShaderBindingTable, in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), pCallableShaderBindingTable, indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdTraceRaysIndirect(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StridedDeviceAddressRegionKHR> pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress)
        {
            // SpanOverloader
            thisApi.CmdTraceRaysIndirect(commandBuffer, in pRaygenShaderBindingTable.GetPinnableReference(), in pMissShaderBindingTable.GetPinnableReference(), in pHitShaderBindingTable.GetPinnableReference(), in pCallableShaderBindingTable.GetPinnableReference(), indirectDeviceAddress);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRayTracingCaptureReplayShaderGroupHandles<T0>(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, dataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRayTracingShaderGroupHandles<T0>(this KhrRayTracingPipeline thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, dataSize, ref pData.GetPinnableReference());
        }

    }
}

