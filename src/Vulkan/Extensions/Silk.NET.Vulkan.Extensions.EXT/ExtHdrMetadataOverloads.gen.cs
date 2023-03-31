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
    public static class ExtHdrMetadataOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void SetHdrMetadata(this ExtHdrMetadata thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainKHR* pSwapchains, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HdrMetadataEXT> pMetadata)
        {
            // SpanOverloader
            thisApi.SetHdrMetadata(device, swapchainCount, pSwapchains, in pMetadata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void SetHdrMetadata(this ExtHdrMetadata thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainKHR> pSwapchains, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] HdrMetadataEXT* pMetadata)
        {
            // SpanOverloader
            thisApi.SetHdrMetadata(device, swapchainCount, in pSwapchains.GetPinnableReference(), pMetadata);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void SetHdrMetadata(this ExtHdrMetadata thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainKHR> pSwapchains, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HdrMetadataEXT> pMetadata)
        {
            // SpanOverloader
            thisApi.SetHdrMetadata(device, swapchainCount, in pSwapchains.GetPinnableReference(), in pMetadata.GetPinnableReference());
        }

    }
}

