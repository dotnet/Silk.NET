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
    [Extension("VK_KHR_surface")]
    public unsafe partial class KhrSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySurfaceKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroySurface([Count(Count = 0)] Instance instance, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroySurface(instance, surface, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySurfaceKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroySurface([Count(Count = 0)] Instance instance, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroySurface(instance, surface, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceSurfaceCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceCapabilitiesKHR* pSurfaceCapabilities)
            => ImplGetPhysicalDeviceSurfaceCapabilities(physicalDevice, surface, pSurfaceCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceSurfaceCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceCapabilitiesKHR pSurfaceCapabilities)
            => ImplGetPhysicalDeviceSurfaceCapabilities(physicalDevice, surface, pSurfaceCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceSurfaceFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Computed = "pSurfaceFormatCount"), Flow(FlowDirection.Out)] SurfaceFormatKHR* pSurfaceFormats)
            => ImplGetPhysicalDeviceSurfaceFormats(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceSurfaceFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pSurfaceFormatCount, [Count(Computed = "pSurfaceFormatCount"), Flow(FlowDirection.Out)] out SurfaceFormatKHR pSurfaceFormats)
            => ImplGetPhysicalDeviceSurfaceFormats(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceSurfacePresentModes([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] PresentModeKHR* pPresentModes)
            => ImplGetPhysicalDeviceSurfacePresentModes(physicalDevice, surface, pPresentModeCount, pPresentModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceSurfacePresentModes([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] out PresentModeKHR pPresentModes)
            => ImplGetPhysicalDeviceSurfacePresentModes(physicalDevice, surface, pPresentModeCount, pPresentModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceSurfaceSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] Bool32* pSupported)
            => ImplGetPhysicalDeviceSurfaceSupport(physicalDevice, queueFamilyIndex, surface, pSupported);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceSurfaceSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] out Bool32 pSupported)
            => ImplGetPhysicalDeviceSurfaceSupport(physicalDevice, queueFamilyIndex, surface, pSupported);

        public KhrSurface(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

