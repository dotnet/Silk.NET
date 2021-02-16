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
    public static class KhrFragmentShadingRateOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetFragmentShadingRate(this KhrFragmentShadingRate thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<Extent2D> pFragmentSize, [Count(Count = 0)] FragmentShadingRateCombinerOpKHR combinerOps)
        {
            // SpanOverloader
            thisApi.CmdSetFragmentShadingRate(commandBuffer, in pFragmentSize.GetPinnableReference(), combinerOps);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceFragmentShadingRates(this KhrFragmentShadingRate thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pFragmentShadingRateCount, [Count(Computed = "pFragmentShadingRateCount"), Flow(FlowDirection.Out)] Span<PhysicalDeviceFragmentShadingRateKHR> pFragmentShadingRates)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceFragmentShadingRates(physicalDevice, pFragmentShadingRateCount, out pFragmentShadingRates.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceFragmentShadingRates(this KhrFragmentShadingRate thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pFragmentShadingRateCount, [Count(Computed = "pFragmentShadingRateCount"), Flow(FlowDirection.Out)] PhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceFragmentShadingRates(physicalDevice, ref pFragmentShadingRateCount.GetPinnableReference(), pFragmentShadingRates);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceFragmentShadingRates(this KhrFragmentShadingRate thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pFragmentShadingRateCount, [Count(Computed = "pFragmentShadingRateCount"), Flow(FlowDirection.Out)] Span<PhysicalDeviceFragmentShadingRateKHR> pFragmentShadingRates)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceFragmentShadingRates(physicalDevice, ref pFragmentShadingRateCount.GetPinnableReference(), out pFragmentShadingRates.GetPinnableReference());
        }

    }
}

