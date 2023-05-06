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
    public static class KhrExternalFenceCapabilitiesOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalFenceProperties = new(StructureType.ExternalFenceProperties);")]
        public static unsafe void GetPhysicalDeviceExternalFenceProperties(this KhrExternalFenceCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalFenceProperties> pExternalFenceProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalFenceProperties(physicalDevice, pExternalFenceInfo, out pExternalFenceProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceExternalFenceProperties(this KhrExternalFenceCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalFenceInfo> pExternalFenceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalFenceProperties(physicalDevice, in pExternalFenceInfo.GetPinnableReference(), pExternalFenceProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalFenceProperties = new(StructureType.ExternalFenceProperties);")]
        public static unsafe void GetPhysicalDeviceExternalFenceProperties(this KhrExternalFenceCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalFenceInfo> pExternalFenceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalFenceProperties> pExternalFenceProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalFenceProperties(physicalDevice, in pExternalFenceInfo.GetPinnableReference(), out pExternalFenceProperties.GetPinnableReference());
        }

    }
}

