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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_cluster_acceleration_structure")]
    public unsafe partial class NVClusterAccelerationStructure : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_cluster_acceleration_structure";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildClusterAccelerationStructureIndirectNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildClusterAccelerationStructureIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClusterAccelerationStructureCommandsInfoNV* pCommandInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildClusterAccelerationStructureIndirectNV", Convention = CallingConvention.Winapi)]
        public partial void CmdBuildClusterAccelerationStructureIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClusterAccelerationStructureCommandsInfoNV pCommandInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetClusterAccelerationStructureBuildSizesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetClusterAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClusterAccelerationStructureInputInfoNV* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        [NativeApi(EntryPoint = "vkGetClusterAccelerationStructureBuildSizesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetClusterAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClusterAccelerationStructureInputInfoNV* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureBuildSizesInfoKHR pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetClusterAccelerationStructureBuildSizesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetClusterAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClusterAccelerationStructureInputInfoNV pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        [NativeApi(EntryPoint = "vkGetClusterAccelerationStructureBuildSizesNV", Convention = CallingConvention.Winapi)]
        public partial void GetClusterAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClusterAccelerationStructureInputInfoNV pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureBuildSizesInfoKHR pSizeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public unsafe AccelerationStructureBuildSizesInfoKHR GetClusterAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ClusterAccelerationStructureInputInfoNV* pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetClusterAccelerationStructureBuildSizes(device, pInfo, out AccelerationStructureBuildSizesInfoKHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public unsafe AccelerationStructureBuildSizesInfoKHR GetClusterAccelerationStructureBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClusterAccelerationStructureInputInfoNV pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetClusterAccelerationStructureBuildSizes(device, in pInfo, out AccelerationStructureBuildSizesInfoKHR silkRet);
            return silkRet;
        }

        public NVClusterAccelerationStructure(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

