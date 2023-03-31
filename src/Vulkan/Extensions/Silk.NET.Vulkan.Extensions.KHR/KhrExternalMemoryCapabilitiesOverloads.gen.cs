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
    public static class KhrExternalMemoryCapabilitiesOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalBufferProperties = new(StructureType.ExternalBufferProperties);")]
        public static unsafe void GetPhysicalDeviceExternalBufferProperties(this KhrExternalMemoryCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalBufferProperties> pExternalBufferProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalBufferProperties(physicalDevice, pExternalBufferInfo, out pExternalBufferProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceExternalBufferProperties(this KhrExternalMemoryCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalBufferInfo> pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalBufferProperties(physicalDevice, in pExternalBufferInfo.GetPinnableReference(), pExternalBufferProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalBufferProperties = new(StructureType.ExternalBufferProperties);")]
        public static unsafe void GetPhysicalDeviceExternalBufferProperties(this KhrExternalMemoryCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalBufferInfo> pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalBufferProperties> pExternalBufferProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalBufferProperties(physicalDevice, in pExternalBufferInfo.GetPinnableReference(), out pExternalBufferProperties.GetPinnableReference());
        }

    }
}

