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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVExternalMemoryCapabilitiesOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceExternalImageFormatProperties(this NVExternalMemoryCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV externalHandleType, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ExternalImageFormatPropertiesNV> pExternalImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceExternalImageFormatProperties(physicalDevice, format, type, tiling, usage, flags, externalHandleType, out pExternalImageFormatProperties.GetPinnableReference());
        }

    }
}

