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
    [Extension("VK_KHR_ray_tracing_pipeline")]
    public unsafe partial class KhrRayTracingPipeline : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_ray_tracing_pipeline";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRayTracingPipelineStackSizeKHR")]
        public partial void CmdSetRayTracingPipelineStackSize([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint pipelineStackSize);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] in RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] in RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] in RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] in RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        public unsafe partial Result GetRayTracingCaptureReplayShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        public partial Result GetRayTracingCaptureReplayShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        public unsafe partial Result GetRayTracingShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        public partial Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupStackSizeKHR")]
        public partial ulong GetRayTracingShaderGroupStackSize([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint group, [Count(Count = 0)] ShaderGroupShaderKHR groupShader);

        public KhrRayTracingPipeline(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

