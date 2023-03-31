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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtOpacityMicromapOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result BuildMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapBuildInfoEXT> pInfos)
        {
            // SpanOverloader
            return thisApi.BuildMicromap(device, deferredOperation, infoCount, in pInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBuildMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapBuildInfoEXT> pInfos)
        {
            // SpanOverloader
            thisApi.CmdBuildMicromap(commandBuffer, infoCount, in pInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyMemoryToMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyMemoryToMicromapInfoEXT> pInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyMemoryToMicromap(commandBuffer, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyMicromapInfoEXT> pInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyMicromap(commandBuffer, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyMicromapToMemory(this ExtOpacityMicromap thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyMicromapToMemoryInfoEXT> pInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyMicromapToMemory(commandBuffer, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdWriteMicromapsProperties(this ExtOpacityMicromap thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapEXT> pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery)
        {
            // SpanOverloader
            thisApi.CmdWriteMicromapsProperties(commandBuffer, micromapCount, in pMicromaps.GetPinnableReference(), queryType, queryPool, firstQuery);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyMemoryToMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyMemoryToMicromapInfoEXT> pInfo)
        {
            // SpanOverloader
            return thisApi.CopyMemoryToMicromap(device, deferredOperation, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyMicromapInfoEXT> pInfo)
        {
            // SpanOverloader
            return thisApi.CopyMicromap(device, deferredOperation, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyMicromapToMemory(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyMicromapToMemoryInfoEXT> pInfo)
        {
            // SpanOverloader
            return thisApi.CopyMicromapToMemory(device, deferredOperation, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MicromapEXT> pMicromap)
        {
            // SpanOverloader
            return thisApi.CreateMicromap(device, pCreateInfo, pAllocator, out pMicromap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapEXT* pMicromap)
        {
            // SpanOverloader
            return thisApi.CreateMicromap(device, pCreateInfo, in pAllocator.GetPinnableReference(), pMicromap);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MicromapEXT> pMicromap)
        {
            // SpanOverloader
            return thisApi.CreateMicromap(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pMicromap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapEXT* pMicromap)
        {
            // SpanOverloader
            return thisApi.CreateMicromap(device, in pCreateInfo.GetPinnableReference(), pAllocator, pMicromap);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MicromapEXT> pMicromap)
        {
            // SpanOverloader
            return thisApi.CreateMicromap(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pMicromap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapEXT* pMicromap)
        {
            // SpanOverloader
            return thisApi.CreateMicromap(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pMicromap);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MicromapEXT> pMicromap)
        {
            // SpanOverloader
            return thisApi.CreateMicromap(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pMicromap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyMicromap(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] MicromapEXT micromap, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyMicromap(device, micromap, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceMicromapCompatibility(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapVersionInfoEXT* pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureCompatibilityKHR> pCompatibility)
        {
            // SpanOverloader
            thisApi.GetDeviceMicromapCompatibility(device, pVersionInfo, out pCompatibility.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceMicromapCompatibility(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapVersionInfoEXT> pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureCompatibilityKHR* pCompatibility)
        {
            // SpanOverloader
            thisApi.GetDeviceMicromapCompatibility(device, in pVersionInfo.GetPinnableReference(), pCompatibility);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceMicromapCompatibility(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapVersionInfoEXT> pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AccelerationStructureCompatibilityKHR> pCompatibility)
        {
            // SpanOverloader
            thisApi.GetDeviceMicromapCompatibility(device, in pVersionInfo.GetPinnableReference(), out pCompatibility.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.MicromapBuildSizesInfoExt);")]
        public static unsafe void GetMicromapBuildSizes(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapBuildInfoEXT* pBuildInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MicromapBuildSizesInfoEXT> pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetMicromapBuildSizes(device, buildType, pBuildInfo, out pSizeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetMicromapBuildSizes(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapBuildInfoEXT> pBuildInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapBuildSizesInfoEXT* pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetMicromapBuildSizes(device, buildType, in pBuildInfo.GetPinnableReference(), pSizeInfo);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.MicromapBuildSizesInfoExt);")]
        public static unsafe void GetMicromapBuildSizes(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapBuildInfoEXT> pBuildInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MicromapBuildSizesInfoEXT> pSizeInfo)
        {
            // SpanOverloader
            thisApi.GetMicromapBuildSizes(device, buildType, in pBuildInfo.GetPinnableReference(), out pSizeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WriteMicromapsProperties<T0>(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapEXT* pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteMicromapsProperties(device, micromapCount, pMicromaps, queryType, dataSize, ref pData.GetPinnableReference(), stride);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WriteMicromapsProperties(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapEXT> pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] nuint stride)
        {
            // SpanOverloader
            return thisApi.WriteMicromapsProperties(device, micromapCount, in pMicromaps.GetPinnableReference(), queryType, dataSize, pData, stride);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WriteMicromapsProperties<T0>(this ExtOpacityMicromap thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapEXT> pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteMicromapsProperties(device, micromapCount, in pMicromaps.GetPinnableReference(), queryType, dataSize, ref pData.GetPinnableReference(), stride);
        }

    }
}

