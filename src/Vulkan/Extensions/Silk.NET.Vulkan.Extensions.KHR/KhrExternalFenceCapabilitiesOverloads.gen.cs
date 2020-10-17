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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrExternalFenceCapabilitiesOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceExternalFenceProperties(this KhrExternalFenceCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ExternalFenceProperties> pExternalFenceProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalFenceProperties(physicalDevice, pExternalFenceInfo, out pExternalFenceProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceExternalFenceProperties(this KhrExternalFenceCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalFenceInfo> pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalFenceProperties(physicalDevice, in pExternalFenceInfo.GetPinnableReference(), pExternalFenceProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceExternalFenceProperties(this KhrExternalFenceCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalFenceInfo> pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ExternalFenceProperties> pExternalFenceProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalFenceProperties(physicalDevice, in pExternalFenceInfo.GetPinnableReference(), out pExternalFenceProperties.GetPinnableReference());
        }

    }
}

