// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_get_display_properties2")]
    public unsafe partial class KhrGetDisplayProperties2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_get_display_properties2";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModeProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDisplayModeProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayModeProperties2KHR* pProperties)
            => ImplGetDisplayModeProperties2(physicalDevice, display, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModeProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDisplayModeProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayModeProperties2KHR pProperties)
            => ImplGetDisplayModeProperties2(physicalDevice, display, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilities2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDisplayPlaneCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] DisplayPlaneInfo2KHR* pDisplayPlaneInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayPlaneCapabilities2KHR* pCapabilities)
            => ImplGetDisplayPlaneCapabilities2(physicalDevice, pDisplayPlaneInfo, pCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilities2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDisplayPlaneCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref DisplayPlaneInfo2KHR pDisplayPlaneInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayPlaneCapabilities2KHR pCapabilities)
            => ImplGetDisplayPlaneCapabilities2(physicalDevice, pDisplayPlaneInfo, pCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceDisplayPlaneProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayPlaneProperties2KHR* pProperties)
            => ImplGetPhysicalDeviceDisplayPlaneProperties2(physicalDevice, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceDisplayPlaneProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayPlaneProperties2KHR pProperties)
            => ImplGetPhysicalDeviceDisplayPlaneProperties2(physicalDevice, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceDisplayProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayProperties2KHR* pProperties)
            => ImplGetPhysicalDeviceDisplayProperties2(physicalDevice, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceDisplayProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayProperties2KHR pProperties)
            => ImplGetPhysicalDeviceDisplayProperties2(physicalDevice, pPropertyCount, pProperties);

        public KhrGetDisplayProperties2(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

