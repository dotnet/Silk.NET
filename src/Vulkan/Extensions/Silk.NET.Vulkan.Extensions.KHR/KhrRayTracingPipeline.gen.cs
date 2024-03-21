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
    [Extension("VK_KHR_ray_tracing_pipeline")]
    public unsafe partial class KhrRayTracingPipeline : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_ray_tracing_pipeline";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRayTracingPipelineStackSizeKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdSetRayTracingPipelineStackSize([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint pipelineStackSize);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] StridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StridedDeviceAddressRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] ulong indirectDeviceAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRayTracingCaptureReplayShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetRayTracingCaptureReplayShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRayTracingShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupStackSizeKHR", Convention = CallingConvention.Winapi)]
        public partial ulong GetRayTracingShaderGroupStackSize([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint group, [Count(Count = 0)] ShaderGroupShaderKHR groupShader);

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, deferredOperation, pipelineCache, (uint) pPipelines.Length, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, deferredOperation, pipelineCache, (uint) pPipelines.Length, pCreateInfos, in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, deferredOperation, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, deferredOperation, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, deferredOperation, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, deferredOperation, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetRayTracingCaptureReplayShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Parameter = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return GetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, (nuint) ((pData.Length) * Unsafe.SizeOf<T0>()), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Parameter = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, (nuint) ((pData.Length) * Unsafe.SizeOf<T0>()), ref pData.GetPinnableReference());
        }

        public KhrRayTracingPipeline(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

