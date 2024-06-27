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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_display")]
    public unsafe partial class KhrDisplay : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_display";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayModeCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModeKHR* pMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayModeCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayModeKHR pMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayModeCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModeKHR* pMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayModeCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayModeKHR pMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayModeCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModeKHR* pMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayModeCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayModeKHR pMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayModeCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModeKHR* pMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayModeCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayModeKHR pMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplaySurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplaySurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplaySurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplaySurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplaySurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplaySurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplaySurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplaySurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayModeProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModePropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayModeProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayModePropertiesKHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayModeProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModePropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayModePropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetDisplayModeProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayModePropertiesKHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayPlaneCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayModeKHR mode, [Count(Count = 0)] uint planeIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPlaneCapabilitiesKHR* pCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetDisplayPlaneCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayModeKHR mode, [Count(Count = 0)] uint planeIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayPlaneCapabilitiesKHR pCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayPlaneSupportedDisplays([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] uint* pDisplayCount, [Count(Parameter = "pDisplayCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayKHR* pDisplays);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayPlaneSupportedDisplays([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] uint* pDisplayCount, [Count(Parameter = "pDisplayCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayKHR pDisplays);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayPlaneSupportedDisplays([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] ref uint pDisplayCount, [Count(Parameter = "pDisplayCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayKHR* pDisplays);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetDisplayPlaneSupportedDisplays([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] ref uint pDisplayCount, [Count(Parameter = "pDisplayCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayKHR pDisplays);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayPlaneProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPlanePropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayPlaneProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayPlanePropertiesKHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayPlaneProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPlanePropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceDisplayPlaneProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayPlanePropertiesKHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayPropertiesKHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceDisplayProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceDisplayProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayPropertiesKHR pProperties);

        public KhrDisplay(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

