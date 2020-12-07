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
    public static class KhrExternalSemaphoreCapabilitiesOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceExternalSemaphoreProperties(this KhrExternalSemaphoreCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ExternalSemaphoreProperties> pExternalSemaphoreProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, pExternalSemaphoreInfo, out pExternalSemaphoreProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceExternalSemaphoreProperties(this KhrExternalSemaphoreCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalSemaphoreInfo> pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, in pExternalSemaphoreInfo.GetPinnableReference(), pExternalSemaphoreProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceExternalSemaphoreProperties(this KhrExternalSemaphoreCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalSemaphoreInfo> pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ExternalSemaphoreProperties> pExternalSemaphoreProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, in pExternalSemaphoreInfo.GetPinnableReference(), out pExternalSemaphoreProperties.GetPinnableReference());
        }

    }
}

