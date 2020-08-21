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
    public static class KhrDeviceGroupCreationOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result EnumeratePhysicalDeviceGroups(this KhrDeviceGroupCreation thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceGroupCount, [Count(Computed = "pPhysicalDeviceGroupCount")] Span<PhysicalDeviceGroupProperties> pPhysicalDeviceGroupProperties)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceGroups(instance, pPhysicalDeviceGroupCount, ref pPhysicalDeviceGroupProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumeratePhysicalDeviceGroups(this KhrDeviceGroupCreation thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] Span<uint> pPhysicalDeviceGroupCount, [Count(Computed = "pPhysicalDeviceGroupCount")] PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceGroups(instance, ref pPhysicalDeviceGroupCount.GetPinnableReference(), pPhysicalDeviceGroupProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumeratePhysicalDeviceGroups(this KhrDeviceGroupCreation thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] Span<uint> pPhysicalDeviceGroupCount, [Count(Computed = "pPhysicalDeviceGroupCount")] Span<PhysicalDeviceGroupProperties> pPhysicalDeviceGroupProperties)
        {
            // SpanOverloader
            return thisApi.EnumeratePhysicalDeviceGroups(instance, ref pPhysicalDeviceGroupCount.GetPinnableReference(), ref pPhysicalDeviceGroupProperties.GetPinnableReference());
        }

    }
}

