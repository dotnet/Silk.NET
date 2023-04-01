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
    public static class ExtToolingInfoOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pToolProperties = new(StructureType.PhysicalDeviceToolProperties);")]
        public static unsafe Result GetPhysicalDeviceToolProperties(this ExtToolingInfo thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceToolProperties> pToolProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceToolProperties(physicalDevice, pToolCount, out pToolProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceToolProperties(this ExtToolingInfo thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceToolProperties* pToolProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceToolProperties(physicalDevice, ref pToolCount.GetPinnableReference(), pToolProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pToolProperties = new(StructureType.PhysicalDeviceToolProperties);")]
        public static unsafe Result GetPhysicalDeviceToolProperties(this ExtToolingInfo thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceToolProperties> pToolProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceToolProperties(physicalDevice, ref pToolCount.GetPinnableReference(), out pToolProperties.GetPinnableReference());
        }

    }
}

