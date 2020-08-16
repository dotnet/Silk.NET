// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_xlib_surface")]
    public unsafe partial class KhrXlibSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_xlib_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateXlibSurfaceKHR")]
        public unsafe partial Result CreateXlibSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] XlibSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateXlibSurfaceKHR")]
        public partial Result CreateXlibSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref XlibSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceXlibPresentationSupportKHR")]
        public unsafe partial Bool32 GetPhysicalDeviceXlibPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] IntPtr* dpy, [Count(Count = 0)] IntPtr visualID);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceXlibPresentationSupportKHR")]
        public partial Bool32 GetPhysicalDeviceXlibPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref IntPtr dpy, [Count(Count = 0)] IntPtr visualID);

        /// <summary>To be added.</summary>
        public unsafe Bool32 GetPhysicalDeviceXlibPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] IntPtr* dpy, [Count(Count = 0)] int visualID)
        {
            // IntPtrOverloader
            return GetPhysicalDeviceXlibPresentationSupport(physicalDevice, queueFamilyIndex, dpy, new IntPtr(visualID));
        }

        /// <summary>To be added.</summary>
        public unsafe Bool32 GetPhysicalDeviceXlibPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref IntPtr dpy, [Count(Count = 0)] int visualID)
        {
            // IntPtrOverloader
            return GetPhysicalDeviceXlibPresentationSupport(physicalDevice, queueFamilyIndex, ref dpy, new IntPtr(visualID));
        }

        public KhrXlibSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

