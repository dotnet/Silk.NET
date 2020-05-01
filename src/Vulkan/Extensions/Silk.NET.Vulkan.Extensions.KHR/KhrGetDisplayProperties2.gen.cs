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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_get_display_properties2")]
    public abstract unsafe partial class KhrGetDisplayProperties2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_get_display_properties2";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModeProperties2KHR")]
        public abstract unsafe Result GetDisplayModeProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayModeProperties2KHR* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModeProperties2KHR")]
        public abstract Result GetDisplayModeProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayModeProperties2KHR pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilities2KHR")]
        public abstract unsafe Result GetDisplayPlaneCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] DisplayPlaneInfo2KHR* pDisplayPlaneInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayPlaneCapabilities2KHR* pCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilities2KHR")]
        public abstract Result GetDisplayPlaneCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref DisplayPlaneInfo2KHR pDisplayPlaneInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayPlaneCapabilities2KHR pCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
        public abstract unsafe Result GetPhysicalDeviceDisplayPlaneProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayPlaneProperties2KHR* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
        public abstract Result GetPhysicalDeviceDisplayPlaneProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayPlaneProperties2KHR pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR")]
        public abstract unsafe Result GetPhysicalDeviceDisplayProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayProperties2KHR* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR")]
        public abstract Result GetPhysicalDeviceDisplayProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayProperties2KHR pProperties);

        public KhrGetDisplayProperties2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

