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
    public static class KhrFragmentShadingRateOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetFragmentShadingRate(this KhrFragmentShadingRate thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent2D* pFragmentSize, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FragmentShadingRateCombinerOpKHR> combinerOps)
        {
            // SpanOverloader
            thisApi.CmdSetFragmentShadingRate(commandBuffer, pFragmentSize, in combinerOps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetFragmentShadingRate(this KhrFragmentShadingRate thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent2D> pFragmentSize, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentShadingRateCombinerOpKHR* combinerOps)
        {
            // SpanOverloader
            thisApi.CmdSetFragmentShadingRate(commandBuffer, in pFragmentSize.GetPinnableReference(), combinerOps);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetFragmentShadingRate(this KhrFragmentShadingRate thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent2D> pFragmentSize, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FragmentShadingRateCombinerOpKHR> combinerOps)
        {
            // SpanOverloader
            thisApi.CmdSetFragmentShadingRate(commandBuffer, in pFragmentSize.GetPinnableReference(), in combinerOps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFragmentShadingRates = new(StructureType.PhysicalDeviceFragmentShadingRateKhr);")]
        public static unsafe Result GetPhysicalDeviceFragmentShadingRates(this KhrFragmentShadingRate thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pFragmentShadingRateCount, [Count(Parameter = "pFragmentShadingRateCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceFragmentShadingRateKHR> pFragmentShadingRates)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceFragmentShadingRates(physicalDevice, pFragmentShadingRateCount, out pFragmentShadingRates.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceFragmentShadingRates(this KhrFragmentShadingRate thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pFragmentShadingRateCount, [Count(Parameter = "pFragmentShadingRateCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceFragmentShadingRates(physicalDevice, ref pFragmentShadingRateCount.GetPinnableReference(), pFragmentShadingRates);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFragmentShadingRates = new(StructureType.PhysicalDeviceFragmentShadingRateKhr);")]
        public static unsafe Result GetPhysicalDeviceFragmentShadingRates(this KhrFragmentShadingRate thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pFragmentShadingRateCount, [Count(Parameter = "pFragmentShadingRateCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceFragmentShadingRateKHR> pFragmentShadingRates)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceFragmentShadingRates(physicalDevice, ref pFragmentShadingRateCount.GetPinnableReference(), out pFragmentShadingRates.GetPinnableReference());
        }

    }
}

