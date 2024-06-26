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
    [Extension("VK_KHR_surface")]
    public unsafe partial class KhrSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_surface";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroySurface([Count(Count = 0)] Instance instance, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySurfaceKHR", Convention = CallingConvention.Winapi)]
        public partial void DestroySurface([Count(Count = 0)] Instance instance, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceCapabilitiesKHR* pSurfaceCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceSurfaceCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceCapabilitiesKHR pSurfaceCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceFormatKHR* pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceFormatKHR pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceFormatKHR* pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceSurfaceFormats([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceFormatKHR pSurfaceFormats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfacePresentModes([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PresentModeKHR* pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfacePresentModes([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PresentModeKHR pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfacePresentModes([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PresentModeKHR* pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceSurfacePresentModes([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PresentModeKHR pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfaceSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Bool32* pSupported);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceSurfaceSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Bool32 pSupported);

        public KhrSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

