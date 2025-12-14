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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVPartitionedAccelerationStructureOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildPartitionedAccelerationStructures(this NVPartitionedAccelerationStructure thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BuildPartitionedAccelerationStructureInfoNV> pBuildInfo)
        {
            // SpanOverloader
            thisApi.CmdBuildPartitionedAccelerationStructures(commandBuffer, in pBuildInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public static unsafe void GetPartitionedAccelerationStructuresBuildSizes(this NVPartitionedAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PartitionedAccelerationStructureInstancesInputNV* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureBuildSizesInfoKHR> pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetPartitionedAccelerationStructuresBuildSizes(device, pInfo, out pSizeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPartitionedAccelerationStructuresBuildSizes(this NVPartitionedAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PartitionedAccelerationStructureInstancesInputNV> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetPartitionedAccelerationStructuresBuildSizes(device, in pInfo.GetPinnableReference(), pSizeInfo);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.AccelerationStructureBuildSizesInfoKhr);")]
        public static unsafe void GetPartitionedAccelerationStructuresBuildSizes(this NVPartitionedAccelerationStructure thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PartitionedAccelerationStructureInstancesInputNV> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureBuildSizesInfoKHR> pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetPartitionedAccelerationStructuresBuildSizes(device, in pInfo.GetPinnableReference(), out pSizeInfo.GetPinnableReference());
        }

    }
}

