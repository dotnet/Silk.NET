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
    public static class KhrExternalMemoryCapabilitiesOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceExternalBufferProperties(this KhrExternalMemoryCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ExternalBufferProperties> pExternalBufferProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalBufferProperties(physicalDevice, pExternalBufferInfo, out pExternalBufferProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceExternalBufferProperties(this KhrExternalMemoryCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalBufferInfo> pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalBufferProperties(physicalDevice, in pExternalBufferInfo.GetPinnableReference(), pExternalBufferProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceExternalBufferProperties(this KhrExternalMemoryCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalBufferInfo> pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ExternalBufferProperties> pExternalBufferProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalBufferProperties(physicalDevice, in pExternalBufferInfo.GetPinnableReference(), out pExternalBufferProperties.GetPinnableReference());
        }

    }
}

