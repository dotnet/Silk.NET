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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtToolingInfoOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceToolProperties(this ExtToolingInfo thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pToolCount, [Count(Computed = "pToolCount"), Flow(FlowDirection.Out)] Span<PhysicalDeviceToolPropertiesEXT> pToolProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceToolProperties(physicalDevice, pToolCount, out pToolProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceToolProperties(this ExtToolingInfo thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pToolCount, [Count(Computed = "pToolCount"), Flow(FlowDirection.Out)] PhysicalDeviceToolPropertiesEXT* pToolProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceToolProperties(physicalDevice, ref pToolCount.GetPinnableReference(), pToolProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceToolProperties(this ExtToolingInfo thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pToolCount, [Count(Computed = "pToolCount"), Flow(FlowDirection.Out)] Span<PhysicalDeviceToolPropertiesEXT> pToolProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceToolProperties(physicalDevice, ref pToolCount.GetPinnableReference(), out pToolProperties.GetPinnableReference());
        }

    }
}

