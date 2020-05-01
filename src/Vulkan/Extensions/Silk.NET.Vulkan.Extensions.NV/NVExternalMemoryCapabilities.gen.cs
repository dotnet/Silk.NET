// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_external_memory_capabilities")]
    public abstract unsafe partial class NVExternalMemoryCapabilities : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_external_memory_capabilities";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
        public abstract unsafe Result GetPhysicalDeviceExternalImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV externalHandleType, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalImageFormatPropertiesNV* pExternalImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
        public abstract Result GetPhysicalDeviceExternalImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV externalHandleType, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalImageFormatPropertiesNV pExternalImageFormatProperties);

        public NVExternalMemoryCapabilities(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

