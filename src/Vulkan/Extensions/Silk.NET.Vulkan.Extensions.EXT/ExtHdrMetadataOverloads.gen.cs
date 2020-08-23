// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtHdrMetadataOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void SetHdrMetadata(this ExtHdrMetadata thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainKHR* pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ReadOnlySpan<HdrMetadataEXT> pMetadata)
        {
            // SpanOverloader
            thisApi.SetHdrMetadata(device, swapchainCount, pSwapchains, in pMetadata.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void SetHdrMetadata(this ExtHdrMetadata thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ReadOnlySpan<SwapchainKHR> pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] HdrMetadataEXT* pMetadata)
        {
            // SpanOverloader
            thisApi.SetHdrMetadata(device, swapchainCount, in pSwapchains.GetPinnableReference(), pMetadata);
        }

        /// <summary>To be added.</summary>
        public static unsafe void SetHdrMetadata(this ExtHdrMetadata thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ReadOnlySpan<SwapchainKHR> pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ReadOnlySpan<HdrMetadataEXT> pMetadata)
        {
            // SpanOverloader
            thisApi.SetHdrMetadata(device, swapchainCount, in pSwapchains.GetPinnableReference(), in pMetadata.GetPinnableReference());
        }

    }
}

