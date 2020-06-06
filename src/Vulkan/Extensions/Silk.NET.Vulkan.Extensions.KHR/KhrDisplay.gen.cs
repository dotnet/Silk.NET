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
    [Extension("VK_KHR_display")]
    public unsafe partial class KhrDisplay : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_display";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] DisplayModeCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayModeKHR* pMode)
            => ImplCreateDisplayMode(physicalDevice, display, pCreateInfo, pAllocator, pMode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ref DisplayModeCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayModeKHR pMode)
            => ImplCreateDisplayMode(physicalDevice, display, pCreateInfo, pAllocator, pMode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DisplaySurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface)
            => ImplCreateDisplayPlaneSurface(instance, pCreateInfo, pAllocator, pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref DisplaySurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface)
            => ImplCreateDisplayPlaneSurface(instance, pCreateInfo, pAllocator, pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModePropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDisplayModeProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayModePropertiesKHR* pProperties)
            => ImplGetDisplayModeProperties(physicalDevice, display, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModePropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDisplayModeProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayModePropertiesKHR pProperties)
            => ImplGetDisplayModeProperties(physicalDevice, display, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDisplayPlaneCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayModeKHR mode, [Count(Count = 0)] uint planeIndex, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayPlaneCapabilitiesKHR* pCapabilities)
            => ImplGetDisplayPlaneCapabilities(physicalDevice, mode, planeIndex, pCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDisplayPlaneCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayModeKHR mode, [Count(Count = 0)] uint planeIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayPlaneCapabilitiesKHR pCapabilities)
            => ImplGetDisplayPlaneCapabilities(physicalDevice, mode, planeIndex, pCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDisplayPlaneSupportedDisplays([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] uint* pDisplayCount, [Count(Computed = "pDisplayCount"), Flow(FlowDirection.Out)] DisplayKHR* pDisplays)
            => ImplGetDisplayPlaneSupportedDisplays(physicalDevice, planeIndex, pDisplayCount, pDisplays);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDisplayPlaneSupportedDisplays([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] ref uint pDisplayCount, [Count(Computed = "pDisplayCount"), Flow(FlowDirection.Out)] out DisplayKHR pDisplays)
            => ImplGetDisplayPlaneSupportedDisplays(physicalDevice, planeIndex, pDisplayCount, pDisplays);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceDisplayPlaneProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayPlanePropertiesKHR* pProperties)
            => ImplGetPhysicalDeviceDisplayPlaneProperties(physicalDevice, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceDisplayPlaneProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayPlanePropertiesKHR pProperties)
            => ImplGetPhysicalDeviceDisplayPlaneProperties(physicalDevice, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceDisplayProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayPropertiesKHR* pProperties)
            => ImplGetPhysicalDeviceDisplayProperties(physicalDevice, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceDisplayProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayPropertiesKHR pProperties)
            => ImplGetPhysicalDeviceDisplayProperties(physicalDevice, pPropertyCount, pProperties);

        public KhrDisplay(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

